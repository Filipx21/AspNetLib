### Sesja: 
* Dane tymczasowo przechowywane sa po stronie serwera (domyślnie - 20min)
* Dane nie sa współdzielone pomiedzy żadaniami / przegladarkami
* Przyklad wykorzystania to koszyk zakupów
* Skalowalność
* Możliwość ustawienia providera
  * InProc - domyslnie, szybko, ale nie dla wielu serwerów
  * State Server - dla wielu serwerów, nie przetrwa restartu
  * SQL - przetrwa restart i dla wielu serwerów
  * Własny 