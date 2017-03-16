# Musify Opdrachtomschrijving
## Inleiding
Dit document dient als opdrachtomschrijving voor Musify. 
In dit document word de applicatie beschrijven zodat iedereen begrijpt wat de applicatie inhoud en baserend op dit document de applicatie kunnen maken.

## Wat is Musify?
Musify is een sharing platform voor muziek. 
Via dit platform kunnen mensen gemakkelijk muziek luisteren, delen, opslaan en natuurlijk hun eigen muziek toevoegen.

## Features
* Genre
* Artiest
* Album
* Lied
* Afspeellijst
* Muziekspeler
* Populaire Pagina's 
* Gebruikers
* Zoekmachine
* Administratie

### Genre
Muziek is te vinden in verschillende Genres, denk aan Rock, Pop, Soul, Blues, House, etc... 
Ook bij Musify word muziek ingedeeld onder Genres zodat je gemakkelijk muziek kan vinden in het genre dat jij leuk vind.

### Artiest
Een liedje is gemaakt door een artiest, het is dan ook handig dat je liedjes kan vinden doormiddel van een artiest, 
of dat je een artiest kan vinden doormiddel van een liedje dat je aan het luisteren bent.
<br>
Iedere artiest heeft zijn eigen pagina met al zijn nummers, albums en informatie over de artiest. 
Daarnaast kan je ook vergelijkbare artiesten bekijken.

### Album
Voor elk album met de benodigde informatie erover. 
Denk aan de artiest van het album, uitgave datum, aantal nummers en een lijst met alle nummers van dat album.

### Liedje
Voor elk nummer is er de benodigde informatie beschikbaar. 
Als je op een bepaald liedje opzoekt, dan krijg je de benodigde informatie te zien. 
De naam van het liedje, de afspeelduur, het album en de artiest.
Voor een nummer zelf word geen pagina gemaakt, er word via het album gefilterd op het nummer.

### Afspeellijst
Je kan zelf een afspeellijst maken en deze gesloten (alleen voor jezelf) of publiekelijk (Voor iedereen toegankelijk) maken.
<br>
Zie je een leuk liedje, of een heel album dat je graag op je afspeellijst wilt hebben? 
Dan kan je gemakkelijk het album of het liedje aan je afspeellijst toevoegen.
Als je een album toevoegt dan worden alle liedjes van dat album aan je afspeellijst toegevoegd.

### Muziekspeler
Met de muziekspeler kan je muziek luisteren. 
Als je op een liedje klikt dan word het afgespeelt met de muziekspeler. 
<br>
Met de muziekspeler kan je muziek pauzeren, naar het volgende of vorige liedje gaan, nummers shufflen en herhalen, 
het volume omhoog en omlaag kunnen zetten, en doorspoelen of terugspoelen doormiddel van een tijdlijn van het liedje.

### Populaire pagina's 
Om een goed overzicht te krijgen wat op het moment veel word geluisterd, zijn er “Populaire Pagina’s”. 
Dat is een overzicht van de populairste onderdelen. 
Denk hierbij aan pagina’s zoals “Populaire Albums”, “Populaire Artiesten”, “Populaire Genres”, De Top 100. 
<br>
Buiten de populaire pagina’s word er ook een “Nieuwe Release” pagina gemaakt, waar de nieuwste muziek word weergegeven.

### Gebruiker
Een gebruiker heeft een gebruikersnaam, een wachtwoord en een email adres. 
Daarnaast kunnen ze optionele informatie toevoegen zoals je naam (Voor en achternaam), geslacht, en een profielfoto toevoegen.
<br>
Gebruikers kunnen ook een afspeellijst maken, en liedjes, albums en artiesten opslaan in “Your Music”, zodat je het gemakkelijk terug kan vinden. 
Ook kan je andere gebruikers of afspeellijsten volgen, zodat je dezelfde muziek kan luisteren. 

### Zoekmachine
Doormiddel van de zoekmachine kan je nummers, artiesten, albums, afspeellijsten en andere gebruikers vinden. 
Hij laad dit overzichtelijk op een rijtje zien, op categorie. 
Alle Artiesten komen onder een tab genaamd Artiesten, alle albums komen op een tab genaamd Albums, etc….
<br>
Als je een artiest invoert, bijvoorbeeld “Childish Gambino”, dan zal de zoekmachine ook de populairste nummers en albums van die artiest laten zien. 

### Administratie
De administratie krijgt een overzicht te zien over de belangrijkste informatie. 
Denk hierbij aan het aantal gebruikers, liedjes, artiesten. Hier kan je ook nog afspeellijsten aan toevoegen (optioneel).

#### Instellingen
Hier kan je de volgende instellingen aanpassen:
* Naam
* Beschrijving
* Logo
* Forcer Login (Je moet inloggen voordat je het platform kan gebruiken)
* Afspeellijst standaard op `Public` zetten.

#### Gebruikers
Ze krijgen een overzicht van alle gebruikers, en kunnen gebruikers toevoegen, aanpassen en verwijderen.

#### Artiesten
Ze krijgen een overzicht van alle artiesten en kunnen artiesten toevoegen, aanpassen, en verwijderen.
<br> <br>
Onderdelen:
* Afbeeldingen (groot & Klein)
* Naam en Genre
* Biografie
* Overzicht van de albums die de artiest heeft.
* Een nieuw album toevoegen (stuurt je door naar `Albums`)

#### Liedjes
Ze krijgen een overzicht van alle nummers en kunnen nummers toevoegen, aanpassen en verwijderen.
<br><br>
Onderdelen:
* Naam
* Album
* Artiest
* Afspeelduur
* Youtube Link		(optioneel)
* Soundcloud Link	(optioneel)

#### Albums
Ze krijgen een overzicht van alle albums en kunnen albums toevoegen, aanpassen en verwijderen.
<br> <br>
Onderdelen:
* Afbeelding ( GRoot & Klein)
* Naam
* Artiest
* Release Datum
* Liedjes

#### Genres
Ze krijgen een overzicht van alle genres en kunnen genres toevoegen, aanpassen en verwijderen.
<br> <br>
Onderdelen:
* Afbeelding
* Naam
* Beschrijving

# Entity-Relationship Diagram
![erDiagram](images/erd.png)

# Database Design
![dbOntwerp] (images/dbo.png)





