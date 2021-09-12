## Najpopularniejsze atrybuty walidacyjne:
* Required
* RegularExpression
* StringLength
* Range

## Inne adnotacje: 
* DataType - Pozwala okreslic typ danych dla np. DisplayFor, EditorFor
* ReadOnly - Tylko do odczytu, nie uzywane przez EditorFor
* DisplayFormat - Formatowanie stringó, tekst dla null
* DisplayColumn - Określa ktore kolumny wyświetlać
* HiddenInput - Wartość w ukrytym polu
* UIHint - Nazwa szablonu HTML dla modelu
* ScaffoldColumn - Ignorowanie kolumny przez helpera
* DisplayName - Nazwa, ktora bedzie przypisana do label

### Walidacja po stroni klienta: 
1. upewnić sie czy istnieja w web.config    
   1.1. <add key="ClientValidationEnabled" value="true"/>
   1.2  <add key="UnobtrusiveJavaScriptEnabled" value="true"/>
2. dodac skrypty:
   2.1 <script src="~/Scripts/jquery-3.4.1.js"></script>
   2.2 <script src="~/Scripts/jquery.validate.js"></script>
   2.3 <script src="~/Scripts/jquery.validate.unobtrusive.js"></script>


  