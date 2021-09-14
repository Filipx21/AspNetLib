### Zmienne statyczne i Application: 
* Znajduja sie po stronie serwera
* Są wspołdzielone między żadaniami, miedzy przegladarkami i użytkownikami
* Zajmują pamieć serwera
* Sa tymczasowe - istnieją do zresetowania tzw. puli aplikacji
* Powoduja problemy z wielowątkowościa
* Przyklad użycia: 
  * Application["key"] = value
  * Statyczne zmienne w aplikacji