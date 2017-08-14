# WcfConsoleApp

**Beschrijving:** Een demo project waarbij ik gebruik maak van een console applicatie en WCF.
- - - -
### Gebruikte technologie ###

* Console App
* WCF
* Entity framework met LINQ extenstion methods voor het uitlezen van JSON
* Repository pattern met mapper

- - - -
### Gebruikte software/tools ###
* Visual Studio (2017)
* ReSharper 
* Power productivity tools 2017
- - - -
### Code/asset beschrijving ###

#### ConsoleApp project ####
**Beschrijving:** Een console applicatie waar bij de gebruiker data kan opvragen via de WCF service. Er zijn twee opties:
1. **"list" optie:** Gebruikersinformatie opvragen en weergeven in tabelvorm met pagina-nummer en -grootte. Dit is de standaard optie.
2. **"email" optie:** Gebruikersinformatie opvragen en weergeven via het opgegeven e-mailadres.

Bestanden/map  | Beschrijving
------------- | -------------
Program.cs  | Opstarten van de Console App
Helpers/AuthorEmailHelper.cs  | Hulp klasse voor de **"email"** optie
Helpers/AuthorListHelper.cs  | Hulp klasse voor de **"list"** optie
Helpers/TextHelper.css  | Hulp klasse voor het weergeven van herhalende tekst-informatie
- - - -

#### WcfService project ####
**Beschrijving:** Service voor het ophalen van data: 
1. **"GetAuthors(int pageIndex, int pageSize)":** Methode voor het ophalen van een reeks van gebruikers.
2. **"GetAuthorByEmail(string email)":** Methode voor het ophalen van een enkele gebruiker via zijn/haar email-adres.

Bestanden/map  | Beschrijving
------------- | -------------
App_Data/authors_data/authors.json  | Fictieve gebruikersdata
Context/AuthorContext.css  | Klasse die verantwoordelijk is voor toegang van data
Mapper/AuthorMapper.cs | Klasse dat een data-object(JToken) naar ander object(Author) omzet
Models/Author.cs | Author model
Repository/AuthorRepository.cs | Author repository klasse
AuthorService.svc.cs | Service met twee opties (GetAuthors, GetAuthorByEmail)