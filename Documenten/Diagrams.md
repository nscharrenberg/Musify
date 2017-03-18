# Musify diagrams Versie 1
## Entity-Relationship Diagram
![erDiagram](images/v1/erd.png)

#### Uitleg
Ik begin de uitleg van de Musify ERD bij de `user`. Dit omdat dit een gemakkelijk start punt is, en alle andere onderdelen op de een of andere manier zijn verbonden aan de `User`. 
<br>
De `User` entiteit heeft een aantal standaard attributen, denk hierbij aan de naam, email en straatnaam. 
<br>
Daarnaast heeft het ook gegevens die nodig zodat je je kan identificeren, denk hierbij aan de gebruikersnaam en wachtwoord, en als laatste is hoe je jezelf presenteerd naar andere doormiddel van een profielfoto.
<br>
De `User` kan een `Free` `User` of een `Paid` `User` zijn. De `Free` `User` krijgt advertenties te zien voordat er een nummer word afgespeeld. De `Paid` `User` krijgt geen advertenties te zijn, maar kan daarnaast ook nog een `Songs` downloaden om offline te beluisteren.
Het systeem controleerd dan ook of de `User` betaald heeft of niet, en indien hij betaald heeft, wanneer de laatste keer is dat hij heeft betaald.
Een `Paid` `User` kan zoveel `Songs` downloaden als de `User` wilt.
<br>
Een `User` kan ook een `Song` opslaan, hierbij hoeft er niet gekeken of het een `Free` of `Paid` user is, aangezien beide groepen dit kunnen doen. 
Als ze een `Song` goed vinden, dan kunnen ze deze aan de `User` koppelen, zodat de `User` de `Song` later gemakkelijk kan terug vinden.
<br>
De `Song` entiteit heeft ook een aantal standaard attributen, denk hierbij aan de naam van de `Song`, de `duration`, en de `url` dat gezocht moet worden als een `User` de `Song` wilt afspelen.
<br>
De `User` kan ook een `Playlist` aanmaken of beluisteren hierbij kan de `User` een `Song` toevoegen aan de `Playlist`. De `User` die de `Playlist` beluisterd zal de `Song` die is toegevoegt dan ook kunnen beluisteren.
Hierbij moet de `Playlist` natuurlijk wel op `Public` staan. De `Playlist` entiteit heeft de attributen `name`, `description`, `image`, en `public`. Waarbij `Public` op true of false kan staan, en dus betekend dat een andere `User` de `Playlist` wel of niet kan beluisteren en zien.
Ook kan een `User` een andere `User` volgen. Zo krijgt de `User` die een andere `User` volgt, notificaties als de gevolgde `User` een nieuwe `Song` of `Playlist` opslaat.
<br>
Als we ons wat meer distantieren van de `User`, dan komen we uit bij een `Album`. Elke `Song` is onderdeel van een `Album`. Een `Song` is maar onderdeel van 1 `Album` en een `Album` kan meerdere `Songs` hebben.
De `Album` entiteit bevat de volgende attributen: `name`, `release_date` en `image`. Waarbij `name` de naam van het album is, de `release_date` de datum van uitgave is en `image` is de album art.
<br>
Een `Album` word gemaakt door een `Artist`, de `Artist` kan dan ook 0 of meer `Albums` hebben.
De `Artist` entiteit heeft de attributen `name`, `image`, en `biography`. de `name` geeft weer wie de `artist` is, de `afbeelding` geeft de `User` wat visualiteit, zodat de `User` weet hoe de `Artist` eruit ziet, en als laatste is er de `biography` waar het leven / de cariere van de `Artist` word weergegeven.
Een `Artist` maakt een bepaalde soort muziek, maar er zijn ook andere `Artists` die soortgelijke muziek maken, of onder hetzelfde rijtje vallen als de `Artist`.
Deze Artists kunnen gekoppeld worden als een `similar` `artist`. Als een `User` een bepaalde `Song` van een `Artist` luisterd, dan zal eronder een rijtje met `similar` `artists` tevoorschijn komen, die de `User` ook andere `Songs` en `Artists` laat ervaren, die de `User` misschien niet kende.
Daarnaast maakt de `Artist` ook nog een bepaald `Genre`, denk hierbij aan pop, rock, electro, r&b, hip hop, country etc... Een `Artist` kan meerdere `Genres` hebben, en `Genres` kunnen gemaakt worden door meerdere `Artists`.
De `Genre` entiteit heeft de attributen `name`, `description` en `image` waarbij eigenlijk hetzelfde geld als bij de andere `entiteiten` die deze attributen hebben gehad.
De `name` staat voor de naam van het `Genre`, de `description` geeft korte uitleg wat het `Genre` inhoud, en de `image` geeft het `Genre` visueel weer.

---

#### Woordenlijst
| Woord 			| 	Uitleg 			|
| ----- 			| ------ 			|
| User  			| Gebruiker			|
| Profile Foto		| Profiel Foto		|
| Password 			| Wachtwoord		|
| name				| naam				|
| username			| gebruikersnaam	|
| has				| heeft				|
| follows			| volgt				|
| Free				| Gratis			|
| Ads				| Advertenties		|
| Paid				| Betaald			|
| Saves				| Opslaan			|
| Playlist 			| Afspeellijst		|
| image				| afbeelding		|
| description		| beschrijving		|
| public 			| publiek / open	|
| Added Toe			| Toegevoegt aan	|
| Song				| Lied				|
| duration			| duur / lengte		|
| url				| link / locatie	|
| is part of		| is onderdeel van	|
| release_date 		| uitbreng datum	|
| Artist			| Artiest			|
| Similar			| soortgelijk 		|
| biography 		| biografie			|
| makes				| maakt				|



## Database Design
![dbDiagram](images/v1/dbo.png)

#### Uitleg
Ook bij het database ontwerp zal ik beginnen bij de `User` met dezelfde reden als bij het ERD.
Het database ontwerp heeft met fields (attributen in ERD), en de relationship ruiten worden nu entiteiten. 
<Br>
De `User` heeft een de standaard gegevens die nodig zijn, en het profiel persoonlijker kunnen maken voor anderen. 
elke `id` is uniek, en word automatisch aan een `User` gebonden. Zo krijgt gebruiker1 het `id` 1, en krijgt gebruiker2 het `id` 2, etc...
<br>
ook zijn `email` en `username` unieke namen, en kunnen deze niet 2x voorkomen in de database. Indien er dus al een `User` is met de naam gebruiker1, dan kan er niet nog een `User` zijn met de naam gebruiker1.
Hetzelfde geld met de `email`, er mag maar 1 `email` zijn, en er kunnen niet 2 `Users` zijn met hetzelfde email address.
<br>
Ook word er gekeken of de `User` al betaald heeft, hiervoor is er een boolean `paid`, dat aangeeft of het een `paid` of `free` `User` is. (zoals te zien in ERD)
Indien de `User` op `paid` staat, dan word er ook gekeken wanneer de laatste keer is dat de `User` heeft betaald. Wanneer de `User` namelijk betaald dan zal de tijd en datum hier opgeslagen worden.
Als de `User` inlogt dan word gecontroleerd of de `User` een `paid` of een `free` user is, en indien `paid` wanneer de laatste keer is.
Als de `User` langer dan een maand geleden betaald heeft, dan word de gebruiker automatisch op `free` gezet.
<br>
net als `User` heeft ook `Song` een `id` die dezelfde functie heeft, maar dan voor de `Songs`.
`Song` heeft opzich dezelfde fields behouden als dat er op het ERD stonden. 
Het enige verschil is dat `url` op het ERD, is vergroot naar 3 fields. Hiervoor kan er een URL voor youtube gebruikt worden `youtube_url`, een url voor soundcloud `soundcloud_url`, maar er moet een url van onze eigen server zijn `server_url`.
Zo kan een `User` ook via externe servers de muziek luisteren, als onze servers overbelast zijn, of traag worden.
<br>
Dan heeft een `Song` ook nog foreign Keys. Deze koppelen entiteiten met elkaar, en zo kan je makkelijk een `Song` koppelen aan een `Album`, doormiddel van het `id`.
In `Song` komt bijvoorbeeld het `id` van het `Album` waarvan de `Song` is.
een `Song` word dan ook gekoppeld met een `Album`, en met een `Artist`.
<br>
Een `User` kan nummers opslaan, dit word bijgehouden in de `song_user` entiteit, dat een relationship was op het ERD (ruit).
Hierbij zijn er 2 Foreign Keys, die de `User` koppelen met de `Song` dat opgeslagen moet worden.
Ook word er bijgehouden wanneer de `User` de `Song` heeft opgeslagen met `created_at`.
<br>
Een `User` kan ook een andere `User` volgen, de relationship die hier op het ERD voor werd gebruikt word nu ook omgezet naar een entiteit, dat beide `Users` opslaat en koppeld met elkaar.
Zo is er een Foreign Key met de naam `Follower_id` dit is de `User` die een andere `USer` volgt, en `followed_id` dat is de `User` dat gevolgt word. Hiervoor word ook bijgehouden wanneer een `User` een andere `User` is gaan volgen.
<br>
De `Playlist` entiteit heeft over het algemeen precies dezelfde fields als op het ERD waren bij de attributen. Hierbij word nu alleen ook bijgehouden wanneer de `Playlist` is aangemaakt, en wanneer het voor de laatste keer is bewerkt, met de `updated_at` field.
Dit houd bij wanneer je de `Playlist` voor het laatst hebt bewerkt door de naam te veranderen, het public te maken, een afbeelding te veranderen, of om een `Song` toe te voegen.
<br>
Als een `User` een `Playlist` maakt, dan word deze gekoppelt doormiddel van de `playlist_user` entiteit. Hierbij word de `id` van de `Playlist` gekoppelt met de `id` van de `User`.
Ook `owner` field word dan op 1 gezet, wat inhoud dat de `User` de maker/eigenaar is van de `Playlist`. 
Wanneer een andere gebruiker deze `Playlist` vervolgens toevoegt, dan is de `owner` 0 voor die `User`, wat betekent dat de `User` niet de eigenaar is van de `Playlist`.
De `User` waarbij `owner` op 1 staat, kan alleen dingen aanpassen en toevoegen, en de `Users` waarbij `owner` op 0 staat, kunnen alleen bekijken en luisteren.
<br>
Je kan natuurlijk ook een `Song` aan een `Playlist` toevoegen, hiervoor is de `playlist_song` entiteit.
Deze koppelt een `Song` aan een `Playlist` doormiddel van de `id`. Ook kan er een bepaalde positie gezet worden voor de `Song`. Zo kan een `Song` als eerste voorkomen, maar ook op een andere positie.
<br>
Elke `Song` heeft 1 `Album`, zoals eerder al is gezegt word er aan een `Song` een `Album` gekoppeld.
De album heeft ook vrijwel dezelfde fields behouden als op het ERD. Het enige is dat de `image` is gesplitst in 2 afbeeldingen. namelijk `img_big_url` en `img_small_url`, dit zijn voor de grote variant en de kleine variant van de `image`.
Een `Album` heeft ook altijd 1 `Artist` en word doormiddel van een Foreign Key aan de `Artist` gekoppelt via het `id` van de `Artist`.
<br>
De `Artist` heeft ook alles behouden, en net als de `Album` alleen de `image` gesplitst in hetzelfde principe.
Een `Artist` heeft ook een soortgelijke `Artist`, dit word in de `similar_artist` entiteit dat eerst een relationship was op het ERD, geregelt.
Hierbij word de `id` van de `Artist` gekoppeld met het `id` van de `Artist` dat hetzelfde soort muziek maakt.
<br>
Een `Song` kan ook andere `Artists` zijn, die mee hebben geholpen aan de `Song`. Hierbij worden de `id` van de `Song` en de `id` van de `Artist` gekoppeld.
en is de `Artist` `featured` in de `Song`.
<br>
De `Genre` bevat ook dezelfde fields als op het ERD is. 
`genre_artist` houd bij welke `Genres` de `Artist` maakt of heeft, en koppelt de `id` van `Genre` met de `id` van `Artist`.


