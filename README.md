# Eventify - Strona internetowa - System rezerwacji biletów

Eventify jest stroną internetową umożliwiającą rezerwację biletów na różne wydarzenia. Projekt został stworzony w oparciu o technologię ASP.NET Core MVC 5, działającą na platformie .NET Framework 4.7.2. Poniżej przedstawiamy opis funkcjonalności oraz struktury projektu.

## Spis treści

- [O projekcie](#o-projekcie)
- [Funkcjonalności](#funkcjonalności)
- [Technologie](#technologie)
- [Struktura projektu](#struktura-projektu)
- [Uruchamianie projektu](#uruchamianie-projektu)
- [Autorzy](#autorzy)
- [Licencja](#licencja)

## O projekcie

Eventify to strona internetowa zapewniająca użytkownikom możliwość rezerwacji biletów na różne wydarzenia. Główne funkcje systemu to: przeglądanie listy dostępnych wydarzeń, tworzenie nowych wydarzeń, edycja istniejących wydarzeń, usuwanie wydarzeń, zarządzanie profilem użytkownika, zarządzanie zakupami w sklepie oraz możliwość tworzenia konta i logowania.

## Funkcjonalności

1. **Strona główna (Landing-page):**
   - Przedstawienie podstawowych informacji o stronie i krótki jej opis.
   - Lista nadchodzących wydarzen.

2. **O nas (About us):**
   - Prezentacja misji i wartości projektu Eventify.

3. **Wydarzenia (Events):**
   - Wyświetlanie listy dostępnych wydarzeń.
   - Możliwość kliknięcia na wydarzenie i wyświetlenia jego szczegółowych informacji.
   - Dodawanie nowego wydarzenia poprzez wypełnienie formularza.
   - Edycja istniejącego wydarzenia.
   - Usuwanie wydarzenia.

4. **Profil użytkownika (Profile):**
   - Wyświetlanie podstawowych informacji o użytkowniku (email, numer telefonu, ilość aktywnych biletów na wydarzenia, ilość wystawionych recenzji).

5. **Sklep (Shop):**
   - Przeglądanie i zarządzanie zakupionymi biletami.
   - Dodawanie biletów do koszyka.

6. **Rejestracja i logowanie:**
   - Możliwość utworzenia konta użytkownika.
   - Logowanie do istniejącego konta.

## Technologie

- ASP.NET Core MVC 5
- .NET Framework 4.7.2
- HTML
- CSS
- JavaScript
- Entity Framework
- Bootstrap

## Struktura projektu

- **Controllers:** Folder zawierający kontrolery aplikacji.
- **Models:** Folder zawierający modele danych (np. Event, User).
- **Views:** Folder zawierający widoki aplikacji (pliki .cshtml).
- **wwwroot:** Folder zawierający pliki statyczne (np. CSS, JavaScript, obrazy).
- **DatabaseContext.cs:** Klasa odpowiedzialna za obsługę bazy danych.
- **Startup.cs:** Klasa konfigurująca aplikację i usługi.
- **README.md:** Aktualny plik README zawierający opis projektu.

## Uruchamianie projektu

Aby uruchomić projekt Eventify, wykonaj następujące kroki:

1. Sklonuj repozytorium na swój komputer.
2. Otwórz projekt w środowisku programistycznym (np. Visual Studio).
3. Upewnij się, że masz zainstalowane wymagane zależności.
4. Skompiluj i uruchom projekt.

## Autorzy

Projekt Eventify został stworzony przez zespół programistów:

- Jan Kowalski - jan.kowalski@example.com
- Anna Nowak - anna.nowak@example.com
- Piotr Wiśniewski - piotr.wisniewski@example.com

## Licencja

Ten projekt jest udostępniony na licencji [MIT License](LICENSE).
