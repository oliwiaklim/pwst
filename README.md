# 🛡️ LifeGuard — System monitorowania aktywności fizycznej seniorów z alertami

Aplikacja webowa wspierająca opiekunów, lekarzy i seniorów w monitorowaniu
aktywności fizycznej (tętno, kroki) oraz automatycznym wykrywaniu anomalii
zdrowotnych i generowaniu alertów w czasie rzeczywistym.

Projekt zrealizowany w ramach przedmiotu [nazwa przedmiotu], WAT.

---

## 🔗 Działające rozwiązanie

| | |
|---|---|
| **Aplikacja (frontend)** | https://lifeguard-frontend-tzc7.onrender.com|
| **API (backend, dokumentacja Swagger)** | https://lifeguard-backend.onrender.com/docs |

### Dane logowania testowych użytkowników

| Rola | E-mail | Hasło |
|---|---|---|
| Opiekun | `opiekun@lifeguard.pl` | `wcy` |
| Senior (podopieczny opiekuna powyżej) | `senior@example.com` | `wcy` |

> Senior po zalogowaniu może zasymulować pomiar tętna i kroków.
> Jeśli wylosowane tętno przekroczy 120 bpm lub spadnie poniżej 40 bpm,
> system automatycznie wygeneruje alert widoczny w panelu przypisanego opiekuna.

---

## 📁 Repozytorium

GitLab: https://gitlab.com/oliwiaklim11/LIFEGUARD

Dostęp dla prowadzącego nadany na poziomie roli **Reporter/Developer**.

---

## 🧩 Architektura i technologie

System realizuje funkcjonalności zdefiniowane w modelu warstwy biznesowej,
aplikacyjnej i technologicznej projektu LifeGuard (rejestracja użytkownika,
monitorowanie aktywności, generowanie alertów, analiza zdrowotna).

| Warstwa | Technologia |
|---|---|
| Frontend | React 18 + Vite |
| Backend / API | Python, FastAPI |
| Baza danych | PostgreSQL |
| ORM / walidacja | SQLAlchemy, Pydantic |
| Hashowanie haseł | Passlib (bcrypt) |
| Hosting | Render.com |

### Diagram przepływu

```
Senior (przeglądarka)               Opiekun (przeglądarka)
        │                                   │
        ▼                                   ▼
   React (frontend) ──── HTTP/JSON ──── React (frontend)
        │                                   │
        └──────────────┬────────────────────┘
                        ▼
              FastAPI (backend, REST API)
                        │
              logika wykrywania anomalii
              (próg tętna: <40 lub >120 bpm)
                        │
                        ▼
                 PostgreSQL (baza danych)
        tabele: users, biometric_data, alerts
```

---

## 📂 Struktura projektu

```
lifeguard/
├── database/
│   └── schema.sql          # skrypt SQL tworzący tabele
├── backend/
│   ├── requirements.txt
│   ├── .env.example        # wzór konfiguracji (bez prawdziwych haseł)
│   └── app/
│       ├── database.py     # połączenie z PostgreSQL
│       ├── models.py       # modele tabel (SQLAlchemy)
│       ├── schemas.py      # walidacja danych (Pydantic)
│       └── main.py         # endpointy API (FastAPI)
└── frontend/
    ├── package.json
    └── src/
        ├── App.jsx
        ├── AuthForm.jsx          # logowanie / rejestracja
        ├── SeniorDashboard.jsx   # panel seniora
        ├── CaregiverDashboard.jsx # panel opiekuna/lekarza
        ├── api.js                # komunikacja z backendem
        └── style.css
```

---

## ⚙️ Funkcjonalności

- **Rejestracja i logowanie** użytkowników w trzech rolach: senior, opiekun, lekarz
- **Symulacja pomiarów biometrycznych** (tętno, liczba kroków) — docelowo zasilane przez HealthKit/urządzenie mobilne
- **Automatyczne wykrywanie anomalii** i generowanie alertów (np. zbyt wysokie/niskie tętno)
- **Panel opiekuna** z listą alertów wszystkich przypisanych podopiecznych, odświeżany na żywo
- **Historia pomiarów** dostępna dla seniora
- **Oznaczanie alertów jako obsłużonych**

---

## 🖥️ Uruchomienie lokalne (instrukcja deweloperska)

### Wymagania
- Python 3.11+
- Node.js (LTS)
- PostgreSQL

### 1. Baza danych
Utwórz bazę `lifeguard_db` i użytkownika z dostępem, następnie wykonaj
zawartość `database/schema.sql` w narzędziu Query Tool (pgAdmin).

### 2. Backend
```powershell
cd backend
python -m venv venv
venv\Scripts\activate
pip install -r requirements.txt
```
Skopiuj `.env.example` jako `.env` i uzupełnij `DATABASE_URL`.
```powershell
uvicorn app.main:app --reload
```
API dostępne pod `http://localhost:8000`, dokumentacja pod `http://localhost:8000/docs`.

### 3. Frontend
```powershell
cd frontend
npm install
npm run dev
```
Aplikacja dostępna pod `http://localhost:5173`.

---

## 👤 Autor

Oliwia Klimaszewska 
