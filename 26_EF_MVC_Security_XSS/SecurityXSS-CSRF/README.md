### Cross Site Scripting (XSS):
[Polega na osadzeniu w treści atakowanej strony kodu dodatkowego kodu JS, 
który może doprowadzić do niepożądanych akcji.] 
* Wstrzykiwanie kodu JS do aplikacji internetowej:
	* Kradzież ciasyteczek (w tym dane sesji),
	* Modyfikacja zawartosci strony internetowej,
* Active injection: Polega na tym, ze strona powtarza wprowadzone przez usera parametry. Takie jak elementy form, querry string.
* Passive injection: Sposób wstrzykniecia informacji do bazy danych.

### Zabezpieczenie:
* Nigdy nie ufaj danym od użytkownika,
* Stosować domyślnych zabezpieczenień przed przeslaniem niebezpiecznej tresci
* Czasami konieczne jest wylącznie (np.CMS):
	* [ValidateInput(false)],
	* Http.Raw - na stronie,
	* Biblioteka AntiXSS (bardzo restrykcyjna), do wyfiltrowania bezpiecznej zawartosci.
	