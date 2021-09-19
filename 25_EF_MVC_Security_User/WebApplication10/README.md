# Bezpieczeństwo w ASP.NET MVC
## ASP.NET Identity: 
### Uwierzytelnienie (Authentication):
* Sprawdzanie tożsamości użytkownika,
* 2 podstawowe typy uwierzytelnienia w ASP.NET MVC:
	* Windows Authentication,
	* Forms Authentication,
* Windows Authentication:
	* Scenariusze internetowe,
	* Logowanie kontem użytkownika Windows,
* Forms Authentication:
	* Scenariusze internetowe,
	* Konieczne zabezpieczenie przez SSL (atrybut [RequireHttps]),
	* Provider - Decyduje o tym gdzie zapisane sa dane użytkowników,
* User.Identity - Aby uzyskać jaki jest aktualnie zalogowany login.
### Autoryzacja (Authorization):
* Atrybut [Authorize]:
	* Roles,
	* Users,
* User.IsInRole(string rola).