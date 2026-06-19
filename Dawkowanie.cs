-- =====================================================================
-- LifeGuard - modul Harmonogram lekow (Medication Reminder)
-- Skrypt DDL - Fizyczny Model Danych (PDM)
-- DBMS: PostgreSQL
-- Wygenerowano z modelu Sparx EA: Luka > Projekt (rozbudowa) > Model danych (LMD)
-- Transformacja: Logical Data Model -> Physical Data Model -> DDL
-- =====================================================================

-- Wymagane rozszerzenie do generowania UUID
CREATE EXTENSION IF NOT EXISTS pgcrypto;

-- =====================================================================
-- Tabela: lek
-- Pochodzenie: klasa domenowa Lek (entity)
-- =====================================================================
CREATE TABLE lek (
    id      UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    nazwa   VARCHAR(150) NOT NULL,
    postac  VARCHAR(50),
    opis    TEXT,

    CONSTRAINT ck_lek_nazwa_not_empty CHECK (length(trim(nazwa)) > 0)
);

COMMENT ON TABLE lek IS 'Slownik lekow dostepnych w systemie LifeGuard';
COMMENT ON COLUMN lek.postac IS 'Postac farmaceutyczna, np. tabletka, syrop, zastrzyk';

-- =====================================================================
-- Tabela: dawkowanie
-- Pochodzenie: klasa domenowa Dawkowanie (entity)
-- Relacje: FK do lek (asocjacja "dotyczy")
-- =====================================================================
CREATE TABLE dawkowanie (
    id                  UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    pacjent_id          UUID NOT NULL,
    lek_id              UUID NOT NULL,
    czestotliwosc       VARCHAR(50) NOT NULL,
    godziny_przyjecia   VARCHAR(200) NOT NULL,
    aktywny             BOOLEAN NOT NULL DEFAULT TRUE,
    utworzono           TIMESTAMP NOT NULL DEFAULT now(),

    CONSTRAINT fk_dawkowanie_lek
        FOREIGN KEY (lek_id) REFERENCES lek(id)
        ON DELETE RESTRICT,

    CONSTRAINT fk_dawkowanie_pacjent
        FOREIGN KEY (pacjent_id) REFERENCES users(id)
        ON DELETE CASCADE
);

COMMENT ON TABLE dawkowanie IS 'Harmonogram dawkowania leku przypisany do pacjenta';
COMMENT ON COLUMN dawkowanie.pacjent_id IS 'FK do tabeli users z istniejacego modulu LifeGuard';
COMMENT ON COLUMN dawkowanie.godziny_przyjecia IS 'Lista godzin w formacie HH:mm, oddzielonych przecinkiem, np. 08:00,14:00,20:00';

-- =====================================================================
-- Tabela: przyjecie_leku
-- Pochodzenie: klasa domenowa PrzyjecieLeku (entity)
-- Relacje: FK do dawkowanie (asocjacja "potwierdza")
-- =====================================================================
CREATE TABLE przyjecie_leku (
    id                  UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    dawkowanie_id       UUID NOT NULL,
    znacznik_czasu      TIMESTAMP NOT NULL,
    status              VARCHAR(20) NOT NULL DEFAULT 'oczekuje',
    czas_potwierdzenia  TIMESTAMP NULL,
    utworzono           TIMESTAMP NOT NULL DEFAULT now(),

    CONSTRAINT fk_przyjecie_dawkowanie
        FOREIGN KEY (dawkowanie_id) REFERENCES dawkowanie(id)
        ON DELETE CASCADE,

    CONSTRAINT ck_przyjecie_status
        CHECK (status IN ('oczekuje', 'przyjety', 'pominiety'))
);

COMMENT ON TABLE przyjecie_leku IS 'Historia przyjec lekow wraz ze statusem (REQ-003, REQ-004, REQ-005)';
COMMENT ON COLUMN przyjecie_leku.status IS 'oczekuje = wyslano przypomnienie, przyjety = pacjent potwierdzil, pominiety = eskalowano do opiekuna';

-- =====================================================================
-- Indeksy
-- =====================================================================
CREATE INDEX idx_dawkowanie_pacjent       ON dawkowanie(pacjent_id);
CREATE INDEX idx_dawkowanie_lek           ON dawkowanie(lek_id);
CREATE INDEX idx_dawkowanie_aktywny       ON dawkowanie(aktywny) WHERE aktywny = TRUE;

CREATE INDEX idx_przyjecie_dawkowanie     ON przyjecie_leku(dawkowanie_id);
CREATE INDEX idx_przyjecie_status         ON przyjecie_leku(status);
CREATE INDEX idx_przyjecie_znacznik_czasu ON przyjecie_leku(znacznik_czasu);

-- Indeks wspierajacy eskalacje (REQ-004): wyszukiwanie oczekujacych przyjec starszych niz 30 min
CREATE INDEX idx_przyjecie_oczekuje_czas
    ON przyjecie_leku(znacznik_czasu)
    WHERE status = 'oczekuje';

-- =====================================================================
-- Koniec skryptu DDL
-- =====================================================================
