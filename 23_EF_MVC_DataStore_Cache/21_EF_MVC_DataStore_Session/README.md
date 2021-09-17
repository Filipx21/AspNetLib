### Cache: 
* Data Caching i Output Caching
  * Data Caching - Reczne z poziomu kodu C#; Podobne do application data.
  * Output Caching - Zapamietywanie zwróconej strony, aby nie trzeba było używać procesora
  * ~ Automatyczne zapamietywanie zwróconej tresci
  * ~ Atrybut dla kontrolera lub akcji
* Działa po stronig serwera, docelowo ma obciążac serwer
* Np. do pobrania danych z bazy danych (jeśli nie ma w Cache) i zapisanie w Cache
* Wielu providerów - Używane do okreslenia w jaki sposob ma działac
* Data Caching - ustawienia
  * Cache Dependencies (np. plik, tablka SQL) - zależność do zewnetrznej struktury; jezeli sie zmieni, wszystko w Cache zniknie
  * Absolute Expiration - ustawienie ile dane maja byc przechowywane w Cache.; Dane sa przetrzymywane w sposóbb absolutny
  * Sliding Expiration - Dane przechowywane na danyc czas, od ostatniego użycia 
  * Priorytet - Decyduje o tym, ktore dane bedą usuwane wcześniej lub pozniej
  * Metoda wywoływana podczac usuwania

### Donut Caching
* Donut Caching:
  * Cachuje cała strone
  * Nie cachowane pod-zapytania (Html.Action)
* Donut Hole Caching: 
  * Nie cachuje całej strony
  * OutputCache dla zapytania (Html.Action)

