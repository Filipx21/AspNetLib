# Helpery
    
    ## Najczesciej wykorzystywane Helpery:
    * Html.Partial - Importowanie kawalka Html
    * Html.Action() - Pozwala na wywolanie akcji kontrollera 
    * Html.ActionLink("ES", "Index", "Home") - Wygenerowanie standardowego linku, prowadzacego do akcji, strony
    * Url.Action("Index", "Home") - Podobny do ActionLink, generuje adres URL (np. to co mamy w src="")
    * Url.Content("~/Content/side.css") - Zwraca adres URL. Uzywany gdy trzeba dodac elementy statyczne
    * Html.Hidden("cos", 1) - Wygeneruje element o typie hidden
    * Html.Password("my-pass") - Pole tekstowe dla hasla
    * Html.Raw() - Pozwala na wstrzyknięcie kawalka html

    ## Dynamiczne Helpery: (Mozna je edytować tworzac template Shared/EditorTemplates/...)
    * EditFor 
    * DisplayFor 
    * Szblony dla typów danych:
    *   * EditorTemplates 
    *   * DisplayTemplates 
    * Atrybuty[UIHint] - przypisanie szablonu np.DateTimePicker


    Warto pobrac, roz dla helperów: http://mvccontrib.codeplex.com/
