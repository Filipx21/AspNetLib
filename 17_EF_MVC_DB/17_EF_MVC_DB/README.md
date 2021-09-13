## Sposoby dostepu do DB: 
* ADO.NET - bezposrednie zapytania
* ORM: 
  * Entity Framework 
  * Dapper
  * nHibernate 
  * Inne


### Entity Framework: 
* DB First - Baza danych juz istnieje
* Model First - Baza danych generowana jest na podstawie modelu
* Code First - Generowanie bazy na podstawie klas


### Code First
* Initializer:
  * CreateDatabaseIfNotExists
  * DropCreateDatabaseIfModelChanges
  * DropCreateDatabaseAlways
  
### Data Annotations:
* Key
* MaxLength
* MinLength
* Required
* Column
* Table
* ConcurrencyCheck
* Timestamp
* ComplexType
* InverseProperty
* ForeignKey
* DatabaseGenerated
* NotMapped