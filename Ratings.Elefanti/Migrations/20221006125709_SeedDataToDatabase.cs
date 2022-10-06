using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ratings.Elefanti.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Movies
            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
                "('The Shawshank Redemption','Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison. However, only Andy knows he didnt commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years.'," +
                "'2h 22m','1994-09-22','./img/shawshank.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
               "('The Godfather','Focuses on the powerful Italian-American crime family of Don Vito Corleone (Marlon Brando). When the dons youngest son, Michael (Al Pacino), reluctantly joins the Mafia, he becomes involved in the inevitable cycle of violence and betrayal. Although Michael tries to maintain a normal relationship with his wife, Kay (Diane Keaton), he is drawn deeper into the family business.'," +
               "'2h 57m','1972-03-24','./img/godfather.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
               "('The Dark Knight','With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.'," +
               "'2h 32m','2008-07-24','./img/darkknight.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
               "('12 Angry Men','Following the closing arguments in a murder trial, the 12 members of the jury must deliberate, with a guilty verdict meaning death for the accused, an inner-city teen. As the dozen men try to reach a unanimous decision while sequestered in a room, one juror (Henry Fonda) casts considerable doubt on elements of the case. Personal issues soon rise to the surface, and conflict threatens to derail the delicate process that will decide one boys fate.'," +
               "'1h 35m','1957-04-20','./img/angrymen.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
               "('Schindlers List','Businessman Oskar Schindler (Liam Neeson) arrives in Krakow in 1939, ready to make his fortune from World War II, which has just started. After joining the Nazi party primarily for political expediency, he staffs his factory with Jewish workers for similarly pragmatic reasons. When the SS begins exterminating Jews in the Krakow ghetto, Schindler arranges to have his workers protected to keep his factory in operation, but soon realizes that in so doing, he is also saving innocent lives.'," +
               "'3h 15m','1994-03-04','./img/schindlerslist.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
               "('Inception','A thief (Leonardo DiCaprio) who enters peoples dreams and steals their secrets gets a shot at redemption when he is given the dangerous task of planting an idea in someones subconscious.'," +
               "'2h 28m','2010-07-22','./img/inception.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
               "('The Matrix','Neo (Keanu Reeves) believes that Morpheus (Laurence Fishburne), an elusive figure considered to be the most dangerous man alive, can answer his question -- What is the Matrix? Neo is contacted by Trinity (Carrie-Anne Moss), a beautiful stranger who leads him into an underworld where he meets Morpheus. They fight a brutal battle for their lives against a cadre of viciously intelligent secret agents. It is a truth that could cost Neo something more precious than his life.'," +
               "'2h 16m','1999-03-31','./img/thematrix.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
              "('Se7en','When retiring police Detective William Somerset (Morgan Freeman) tackles a final case with the aid of newly transferred David Mills (Brad Pitt), they discover a number of elaborate and grisly murders. They soon realize they are dealing with a serial killer (Kevin Spacey) who is targeting people he thinks represent one of the seven deadly sins. Somerset also befriends Mills wife, Tracy (Gwyneth Paltrow), who is pregnant and afraid to raise her child in the crime-riddled city.'," +
              "'2h 5m','1995-09-22','./img/se7en.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
              "('Its a Wonderful Life','After George Bailey (James Stewart) wishes he had never been born, an angel (Henry Travers) is sent to earth to make Georges wish come true. George starts to realize how many lives he has changed and impacted, and how they would be different if he was never there.'," +
              "'2h 9m','1947-01-07','./img/wonderfullife.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
              "('Interstellar','In Earths future, a global crop blight and second Dust Bowl are slowly rendering the planet uninhabitable. Professor Brand (Michael Caine), a brilliant NASA physicist, is working on plans to save mankind by transporting Earths population to a new home via a wormhole. But first, Brand must send former NASA pilot Cooper (Matthew McConaughey) and a team of researchers through the wormhole and across the galaxy to find out which of three planets could be mankinds new home.'," +
              "'2h 45m','2014-11-07','./img/interstellar.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
              "('Parasite','Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.'," +
              "'2h 12m','2014-11-06','./img/parasite.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
             "('The Pianist','In this adaptation of the autobiography The Pianist:The Extraordinary True Story of One Mans Survival in Warsaw, 1939-1945, Wladyslaw Szpilman (Adrien Brody), a Polish Jewish radio station pianist, sees Warsaw change gradually as World War II begins. Szpilman is forced into the Warsaw Ghetto, but is later separated from his family during Operation Reinhard. From this time until the concentration camp prisoners are released, Szpilman hides in various locations among the ruins of Warsaw.'," +
             "'2h 28m','2002-12-27','./img/pianist.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
           "('Aliens','On planet LV-426, Ripley (Sigourney Weaver) and a dwindling number of Marines battle an almost-unstoppable army of monstrous predators which wiped out an entire colony of humans, save for one little girl (Carrie Henn).'," +
           "'2h 17m','1986-07-18','./img/aliens.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
           "('Oldboy','Dae-Su is an obnoxious drunk bailed from the police station yet again by a friend. However, he is abducted from the street and wakes up in a cell, where he remains for the next 15 years, drugged unconscious when human contact is unavoidable, otherwise with only the television as company. And then, suddenly released, he is invited to track down his jailor with a denouement that is simply stunning.'," +
           "'1h 58m','2005-03-25','./img/oldboy.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
           "('Joker','Forever alone in a crowd, failed comedian Arthur Fleck seeks connection as he walks the streets of Gotham City. Arthur wears two masks -- the one he paints for his day job as a clown, and the guise he projects in a futile attempt to feel like he is part of the world around him. Isolated, bullied and disregarded by society, Fleck begins a slow descent into madness as he transforms into the criminal mastermind known as the Joker.'," +
           "'2h 2m','2019-10-04','./img/joker.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
           "('Coco','Despite his familys generations-old ban on music, young Miguel dreams of becoming an accomplished musician like his idol Ernesto de la Cruz. Desperate to prove his talent, Miguel finds himself in the stunning and colorful Land of the Dead. After meeting a charming trickster named Héctor, the two new friends embark on an extraordinary journey to unlock the real story behind Miguels family history.'," +
           "'1h 49m','2017-11-22','./img/coco.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
           "('Your Name','A teenage boy and girl embark on a quest to meet each other for the first time after they magically swap bodies.'," +
           "'1h 46m','2017-04-07','./img/yourname.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
          "('3 Idiots','In college, Farhan and Raju form a great bond with Rancho due to his positive and refreshing outlook to life. Years later, a bet gives them a chance to look for their long-lost friend whose existence seems rather elusive.'," +
          "'2h 40m','2009-12-25','./img/3idiots.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
          "('Hamilton','The original Broadway production of the award-winning musical that tells the story of Alexander Hamilton, first secretary of the treasury, blending hip-hop, jazz, R&B and Broadway styles, filmed from the Richard Rogers Theater in New York.'," +
          "'2h 40m','2020-07-03','./img/hamilton.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
          "('Up','A 78-year-old balloon salesman (Ed Asner) ties thousands of balloons to his house and flies to South America, but discovers too late a young stowaway aboard.'," +
          "'1h 29m','2009-03-29','./img/up.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
          "('Like Stars on Earth','Ishaan, a student who has dyslexia, cannot seem to get anything right at his boarding school. Soon, a new unconventional art teacher, Ram Shankar Nikumbh, helps him discover his hidden potential.'," +
          "'2h 45m','2007-12-21','./img/starsonearth.jpg')");

            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
          "('The Terminator','Disguised as a human, a cyborg assassin known as a Terminator (Arnold Schwarzenegger) travels from 2029 to 1984 to kill Sarah Connor (Linda Hamilton). Sent to protect Sarah is Kyle Reese (Michael Biehn), who divulges the coming of Skynet, an artificial intelligence system that will spark a nuclear holocaust. Sarah is targeted because Skynet knows that her unborn son will lead the fight against them. With the virtually unstoppable Terminator in hot pursuit, she and Kyle attempt to escape.'," +
          "'1h 48m','1984-10-26','./img/terminator.jpg')");

            // Genres

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Drama')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Crime')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Action')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('History')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Science fiction')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Thriller')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Mystery')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Comedy')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Animation')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Adventure')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Romance')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Musical')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Fantasy')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Horror')");

            migrationBuilder.Sql("INSERT INTO Genres(GenreName) VALUES" +
                "('Holiday')");

            //Movie Genres

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(1,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(2,2)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(2,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(3,3)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(3,2)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(3,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(4,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(4,2)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
                "(5,4)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(5,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(6,3)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(6,10)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(7,3)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(7,5)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(8,2)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(8,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(8,7)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(9,15)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(9,8)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(9,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(10,5)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(10,10)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(10,3)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(11,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(11,6)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(12,4)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(12,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(13,3)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(13,10)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(13,5)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(14,7)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(14,6)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(15,2)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(15,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(16,8)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(16,10)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(16,9)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(17,13)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(17,11)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(17,9)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(18,8)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(18,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(19,12)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(19,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(20,9)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(20,10)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(20,8)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(21,1)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(22,5)");

            migrationBuilder.Sql("INSERT INTO MovieGenres(MovieId,GenreId) VALUES" +
               "(22,3)");

            //People

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Tim','Robbis','1958-10-16','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Morgan','Freeman','1937-06-01','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Bob','Gunton','1945-11-15','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Frank','Darabont','1959-01-28','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Stephen','King','1947-09-21','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Frank','Darabont','1959-01-28','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Marlon','Brando','1924-04-03','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Al','Pacino','1940-04-25','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('James','Caan','1940-03-26','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Francis Ford','Coppola','1939-04-07','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Mario','Puzo','1920-10-15','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Francis Ford','Coppola','1939-04-07','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Christian','Bale','1974-01-30','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Heath','Ledger','1979-04-04','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Aaron','Eckhart','1968-03-12','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Christopher','Nolan','1970-07-30','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Jonathan','Nolan','1976-06-06','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
                "('Christopher','Nolan','1970-07-30','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('David S.','Goyer','1965-12-22','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Honda','Fonda','1905-05-16','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lee J.','Cobb','1911-12-08','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Martin','Balsam','1919-11-04','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Sidney','Lumet','1924-06-25','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Reginald','Rose','1920-12-10','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Liam','Neeson','1952-06-07','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Ralph','Fiennes','1962-12-22','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Ben','Kingsley','1943-12-31','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Steven','Spielberg','1946-12-18','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Thomas','Keneally','1935-10-07','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Steven','Zaillian','1953-01-30','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Leonardo','DiCaprio','1974-11-11','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Joseph','Gordon-Levitt','1981-02-17','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Elliot','Page','1987-02-21','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Keanu','Reeves','1964-09-02','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Laurence','Fishburne','1961-07-30','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Carrie-Anne','Moss','1967-08-21','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lilly','Wachowski','1967-12-29','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lilly','Wachowski','1967-12-29','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lana','Wachowski','1965-06-21','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lana','Wachowski','1965-06-21','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Brad','Pitt','1963-12-18','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Kevin','Spacey','1959-07-26','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('David','Fincher','1962-08-28','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Andrew Kevin','Walker','1964-08-14','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('James','Stewart','1908-05-20','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Donna','Reed','1921-01-27','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lionel','Barrymore','1878-04-28','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Frank','Capra','1897-05-18','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Frances','Goodrich','1890-12-21','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Albert','Hackett','1900-02-16','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Frank','Capra','1897-05-18','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Matthew','McConaughey','1969-11-04','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Anne','Hathaway','1982-11-12','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Jessica','Chastain','1977-03-24','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Song','Kang-ho','1967-01-17','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lee','Sun-kyun','1975-03-02','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Cho','Yeo-jeong','1981-02-10','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Bong','Joon Ho'','1969-09-14','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Han','Jin-won','1986-01-01','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Bong','Joon Ho','1969-09-14','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Adrien','Brody','1973-04-14','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Thomas','Kretschmann','1962-09-08','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Frank','Finlay','1926-08-06','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Roman','Polanski','1933-08-18','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Ronald','Harwood','1934-11-09','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Wladyslaw','Szpilman','1911-01-01','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Sigourney','Weaver','1949-10-08','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Michael','Biehn','1956-07-31','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Carrie','Henn','1976-05-07','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('James','Cameron','1954-10-16','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('James','Cameron','1954-10-16','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('David','Giler','1943-07-23','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Walter','Hill','1942-01-10','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Choi','Min-sik','1962-01-22','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Yoo','Ji-tae','1976-04-13','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Kang','Hye-jeong','1982-01-04','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Park','Chan-wook','1963-08-23','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Garon','Tsuchiya','1947-01-01','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Nobuaki','Minegishi','1959-06-15','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Joaquin','Phoenix','1974-10-28','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Robert','De Niro','1943-08-17','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Zazie','Beetz','1991-06-01','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Todd','Phillips','1970-12-20','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Todd','Phillips','1970-12-20','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Scott','Silver','1964-11-30','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Bob','Kane','1915-10-24','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Anthony','Gonzalez','2004-09-23','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Gael Garcia','Bernal','1978-11-30','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Benjamin','Bratt','1963-12-16','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lee','Unkrich','1967-10-08','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Adrian','Molina','1985-10-23','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Jason','Katz','1960-05-07','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Matthew','Aldrich','1979-06-24','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lee','Unkrich','1967-10-08','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Ryûnosuke','Kamiki','1993-05-19','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Mone','Kamishiraishi','1998-01-27','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Ryo','Narita','1993-11-22','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Makoto','Shinkai','1973-02-09','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Makoto','Shinkai','1973-02-09','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Aamir','Khan','1965-03-14','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Ranganathan','Madhavan','1970-06-01','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Mona','Singh','1981-10-08','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Rajkumar','Hirani','1962-11-20','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Rajkumar','Hirani','1962-11-20','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Abhijat','Joshi','1969-12-01','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Vidhu Vinod','Chopra','1952-09-05','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lin-Manuel','Miranda','1980-01-16','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Phillipa','Soo','1990-03-31','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Leslie','Odom Jr.','1981-08-06','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Thomas','Kail','1978-01-30','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Lin-Manuel','Miranda','1980-01-16','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
              "('Ron','Chernow','1949-03-03','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Edward','Asner','1929-11-15','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Jordan','Nagai','2000-02-05','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('John','Ratzenberger','1947-04-06','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Pete','Docter','1968-10-09','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Bob','Peterson','1961-01-09','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Pete','Docter','1968-10-09','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Bob','Peterson','1961-01-09','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Tom','McCarthy','1966-06-07','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Darsheel','Safary','1997-03-09','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Tisca','Chopra','1973-11-01','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Aamir','Khan','1965-03-14','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Amole','Gupte','1962-01-01','Director')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
              "('Amole','Gupte','1962-01-01','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Arnold','Schwarzenegger','1947-07-30','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Linda','Hamilton','1956-09-26','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
               "('Michael','Biehn','1956-07-31','Actor')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
             "('Gale Anne','Hurd','1955-10-25','Writer')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate,Discriminator) VALUES" +
             "('William','Wisher','1958-09-01','Writer')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
