﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ratings.Elefanti.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            InsertMovies(migrationBuilder);

            InsertGenres(migrationBuilder);

            InsertMovieGenres(migrationBuilder);

            InsertPeople(migrationBuilder);

            InsertMovieActors(migrationBuilder);

            InsertMovieDirectors(migrationBuilder);

            InsertMovieWriters(migrationBuilder);

            InsertMovieRatings(migrationBuilder);

            InsertMovieComments(migrationBuilder);
        }


        private void InsertMovies(MigrationBuilder migrationBuilder)
        {
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
        }
        private void InsertGenres(MigrationBuilder migrationBuilder)
        {

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
        }
        private void InsertMovieGenres(MigrationBuilder migrationBuilder)
        {

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
        }
        private void InsertPeople(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
              "('Tim','Robbis','1958-10-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Morgan','Freeman','1937-06-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Bob','Gunton','1945-11-15')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Frank','Darabont','1959-01-28')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Stephen','King','1947-09-21')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Frank','Darabont','1959-01-28')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Marlon','Brando','1924-04-03')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Al','Pacino','1940-04-25')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('James','Caan','1940-03-26')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Francis Ford','Coppola','1939-04-07')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Mario','Puzo','1920-10-15')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Francis Ford','Coppola','1939-04-07')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Christian','Bale','1974-01-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Heath','Ledger','1979-04-04')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Aaron','Eckhart','1968-03-12')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Christopher','Nolan','1970-07-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Jonathan','Nolan','1976-06-06')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
                "('Christopher','Nolan','1970-07-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('David S.','Goyer','1965-12-22')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Honda','Fonda','1905-05-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lee J.','Cobb','1911-12-08')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Martin','Balsam','1919-11-04')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Sidney','Lumet','1924-06-25')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Reginald','Rose','1920-12-10')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Liam','Neeson','1952-06-07')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Ralph','Fiennes','1962-12-22')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Ben','Kingsley','1943-12-31')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Steven','Spielberg','1946-12-18')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Thomas','Keneally','1935-10-07')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Steven','Zaillian','1953-01-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Leonardo','DiCaprio','1974-11-11')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Joseph','Gordon-Levitt','1981-02-17')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Elliot','Page','1987-02-21')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Keanu','Reeves','1964-09-02')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Laurence','Fishburne','1961-07-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Carrie-Anne','Moss','1967-08-21')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lilly','Wachowski','1967-12-29')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lilly','Wachowski','1967-12-29')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lana','Wachowski','1965-06-21')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lana','Wachowski','1965-06-21')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Brad','Pitt','1963-12-18')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Kevin','Spacey','1959-07-26')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('David','Fincher','1962-08-28')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Andrew Kevin','Walker','1964-08-14')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('James','Stewart','1908-05-20')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Donna','Reed','1921-01-27')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lionel','Barrymore','1878-04-28')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Frank','Capra','1897-05-18')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Frances','Goodrich','1890-12-21')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Albert','Hackett','1900-02-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Frank','Capra','1897-05-18')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Matthew','McConaughey','1969-11-04')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Anne','Hathaway','1982-11-12')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Jessica','Chastain','1977-03-24')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Song','Kang-ho','1967-01-17')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lee','Sun-kyun','1975-03-02')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Cho','Yeo-jeong','1981-02-10')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Bong','Joon Ho','1969-09-14')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Han','Jin-won','1986-01-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Bong','Joon Ho','1969-09-14')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Adrien','Brody','1973-04-14')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Thomas','Kretschmann','1962-09-08')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Frank','Finlay','1926-08-06')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Roman','Polanski','1933-08-18')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Ronald','Harwood','1934-11-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Wladyslaw','Szpilman','1911-01-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Sigourney','Weaver','1949-10-08')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Michael','Biehn','1956-07-31')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Carrie','Henn','1976-05-07')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('James','Cameron','1954-10-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('James','Cameron','1954-10-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('David','Giler','1943-07-23')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Walter','Hill','1942-01-10')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Choi','Min-sik','1962-01-22')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Yoo','Ji-tae','1976-04-13')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Kang','Hye-jeong','1982-01-04')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Park','Chan-wook','1963-08-23')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Garon','Tsuchiya','1947-01-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Nobuaki','Minegishi','1959-06-15')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Joaquin','Phoenix','1974-10-28')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Robert','De Niro','1943-08-17')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Zazie','Beetz','1991-06-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Todd','Phillips','1970-12-20')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Todd','Phillips','1970-12-20')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Scott','Silver','1964-11-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Bob','Kane','1915-10-24')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Anthony','Gonzalez','2004-09-23')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Gael Garcia','Bernal','1978-11-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Benjamin','Bratt','1963-12-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lee','Unkrich','1967-10-08')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Adrian','Molina','1985-10-23')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Jason','Katz','1960-05-07')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Matthew','Aldrich','1979-06-24')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lee','Unkrich','1967-10-08')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Ryûnosuke','Kamiki','1993-05-19')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Mone','Kamishiraishi','1998-01-27')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Ryo','Narita','1993-11-22')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Makoto','Shinkai','1973-02-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Makoto','Shinkai','1973-02-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Aamir','Khan','1965-03-14')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Ranganathan','Madhavan','1970-06-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Mona','Singh','1981-10-08')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Rajkumar','Hirani','1962-11-20')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Rajkumar','Hirani','1962-11-20')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Abhijat','Joshi','1969-12-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Vidhu Vinod','Chopra','1952-09-05')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lin-Manuel','Miranda','1980-01-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Phillipa','Soo','1990-03-31')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Leslie','Odom Jr.','1981-08-06')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Thomas','Kail','1978-01-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Lin-Manuel','Miranda','1980-01-16')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
              "('Ron','Chernow','1949-03-03')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Edward','Asner','1929-11-15')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Jordan','Nagai','2000-02-05')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('John','Ratzenberger','1947-04-06')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Pete','Docter','1968-10-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Bob','Peterson','1961-01-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Pete','Docter','1968-10-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Bob','Peterson','1961-01-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Tom','McCarthy','1966-06-07')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Darsheel','Safary','1997-03-09')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Tisca','Chopra','1973-11-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Aamir','Khan','1965-03-14')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Amole','Gupte','1962-01-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
              "('Amole','Gupte','1962-01-01')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Arnold','Schwarzenegger','1947-07-30')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Linda','Hamilton','1956-09-26')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
               "('Michael','Biehn','1956-07-31')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
             "('Gale Anne','Hurd','1955-10-25')");

            migrationBuilder.Sql("INSERT INTO People(Name,Surname,BirthDate) VALUES" +
             "('William','Wisher','1958-09-01')");
        }
        private void InsertMovieActors(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(1,1,'Andy Dufresne')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(1,2,'Red')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(1,3,'Warden Norton')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(2,4,'Don Vito Corleone')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(2,5,'Michael')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(2,6,'Sonny')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(3,7,'Bruce Wayne Batman')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(3,8,'Joker')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(3,9,'Harvey Dent')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(4,10,'Juror 8')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(4,11,'Juror 3')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(4,12,'Juror 1')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(5,13,'Oskar Schindler')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(5,14,'Amon Goeth')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(5,15,'Itzhak Stern')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(6,16,'Cobb')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(6,17,'Arthur')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(6,18,'Ariadne')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(7,19,'Neo')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(7,20,'Morpheus')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(7,21,'Trinity')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(8,2,'Somerset')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(8,23,'Mills')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(8,24,'John Doe')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(9,25,'George Bailey')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(9,26,'Mary Hatch')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(9,27,'Mr. Potter')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(10,28,'Cooper')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(10,29,'Brand')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(10,30,'Murph')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(11,31,'Ki Taek')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(11,32,'Dong Ik')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(11,33,'Yeon Kyo')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(12,34,'Wladyslaw Szpilman')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(12,35,'Captain Wilm Hosenfeld')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(12,36,'Father')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(13,37,'Ripley')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(13,38,'Corporal Hicks')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(13,39,'Newt')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(14,40,'Dae-su Oh')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(14,41,'Woo-jin Lee')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(14,42,'Mi-do')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(15,43,'Arthur Fleck')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(15,44,'Murray Franklin')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(15,45,'Sophie Dumond')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(16,46,'Miguel')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(16,47,'Héctor')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(16,48,'Ernesto de la Cruz')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(17,49,'Taki Tachibana')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(17,50,'Mitsuha Miyamizu')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(17,51,'Katsuhiko Teshigawara')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(18,52,'Phunsukh Wangdu')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(18,53,'Farhan Qureshi')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(18,54,'Mona Sahastrabuddhe')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(19,55,'Alexander Hamilton')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(19,56,'Eliza Hamilton')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(19,57,'Aaron Burr')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(20,58,'Carl Fredricksen')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(20,59,'Russell')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(20,60,'Construction Foreman Tom')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(21,61,'Ishaan Awasthi')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(21,52,'Ram Shankar Nikumbh')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(21,63,'Maya Awasthi')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(22,64,'The Terminator')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(22,65,'Sarah Connor')");

            migrationBuilder.Sql("INSERT INTO MovieActors(MovieId,ActorId,CharacterName) VALUES" +
             "(22,66,'Kyle Reese')");
        }
        private void InsertMovieDirectors(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(1,1)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(2,2)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(3,3)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(4,4)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(5,5)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(6,3)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(7,7)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(7,6)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(8,8)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(9,9)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(10,3)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(11,10)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(12,11)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(13,12)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(14,13)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(15,14)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(16,15)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(16,16)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(17,17)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(18,18)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(19,19)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(20,20)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(20,21)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(21,22)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(21,23)");

            migrationBuilder.Sql("INSERT INTO MovieDirectors(MovieId,DirectorId) VALUES" +
             "(22,12)");
        }
        private void InsertMovieWriters(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(1,1,'Novel writer')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(1,2,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(2,3,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(2,4,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(3,5,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(3,6,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(3,7,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(4,8,'Teleplay Twelve Angry Men')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(5,9,'Book')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(5,10,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(6,6,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(7,11,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(7,12,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(8,13,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(9,14,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(9,15,'ScreenPlay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(9,16,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(10,5,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(10,6,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(11,18,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(11,17,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(12,19,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(12,20,'Book')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(13,21,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(13,22,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(13,23,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(14,24,'Manga')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(14,25,'Manga')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(15,26,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(15,27,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(15,28,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(16,31,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(16,29,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(16,30,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(17,32,'Novel')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(18,33,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(18,34,'Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(18,35,'Screenplay associate')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(19,36,'Book')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(19,37,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(20,38,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(20,39,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(20,40,'Story')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(21,41,'Dialogue and Screenplay')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(22,21,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(22,42,'')");

            migrationBuilder.Sql("INSERT INTO MovieWriters(MovieId,WriterId,Credit) VALUES" +
             "(22,43,'Aditional dialogue')");

        }
        private void InsertMovieRatings(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(1,1,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(1,2,10)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(1,5,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(2,4,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(2,2,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(3,6,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(3,3,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(4,9,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(4,8,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(5,7,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(5,9,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(6,11,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(6,13,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(7,11,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(7,8,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(8,6,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(9,12,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(9,8,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(9,10,6)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(10,5,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(10,8,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(11,6,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(11,4,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(12,8,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(12,14,6)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(13,8,6)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(13,9,5)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(14,6,6)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(15,5,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(15,12,6)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(16,8,5)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(16,12,4)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(17,10,6)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(17,6,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(18,11,5)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(18,5,6)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(19,8,7)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(20,9,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(21,10,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(21,6,9)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(22,13,8)");

            migrationBuilder.Sql("INSERT INTO Ratings(MovieId,UserId,RatingNr) VALUES" +
             "(22,6,8)");
        }
        private void InsertMovieComments(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(1,2,'The best of the best 10/10!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(1,5,'Im so glad I took the time to see this!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(1,8,'I think this is a masterpiece!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(1,1,'After so many good reviews for this movie I expected more!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(1,6,'Wonderful movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(2,3,'Such a good movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(2,9,'Avesome!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(2,11,'Could be better!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(2,7,'I would see that again! I loved all the finer details of the movie, and I want to experience them all over again.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(2,5,'Expected more!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(3,5,'An excellent movie.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(3,8,'I didnt want it to end at all.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(3,2,'Avesome!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(3,10,'Expected more! Disappointed.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(3,7,'I would see that again and again.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(4,6,'In love with this movie.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(4,9,'Didnt want it to end.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(4,12,'I want to watch it over and over again!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(4,3,'I expected more!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(4,8,'So disappointed!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(5,8,'Could be better!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(5,12,'I think this was a masterpiece!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(5,2,'I dont often rewatch movies, but I know that this one deserves it.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(5,2,'I love it!!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(5,2,'Expected more!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(6,10,'Love it!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(6,6,'I loved every second.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(6,4,'Could be better!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(6,8,'Couldnt believe I lost my time for this movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(6,9,'Diasppointed!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(7,2,'Disappointed!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(7,3,'I want to watch it over and over again!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(7,7,'Didnt want it to end!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(7,9,'The best movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(7,11,'Could be better!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(8,12,'Sooo good!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(8,4,'Expected more!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(8,6,'I loved every second!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(8,5,'The best movie of all the time!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(8,7,'Wonderfull movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(9,4,'Couldnt wait for it!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(9,6,'Didnt want it to end!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(9,8,'Great movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(9,11,'The best of all the time!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(9,9,'In love with this movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(10,14,'Expected more!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(10,1,'Great movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(10,5,'In love with every second of it!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(10,7,'Could be better!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(10,8,'The best!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(11,9,'Good movie.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(11,5,'The best movie.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(11,6,'I will watch it over and over again.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(11,8,'Expected more.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(11,11,'Could be better.')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(12,2,'Not how I expected!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(12,7,'The best movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(12,11,'The greatest of all the time!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(12,6,'In love with this movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(12,4,'I expected more!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(13,8,'Such a good movie!!!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(13,3,'Great movie!!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(13,7,'I will watch it over and over again!!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(13,11,'OMGG in love with this movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(13,13,'Expected more!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(14,10,'The best!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(14,12,'The greatest of all the time!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(14,8,'The best movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(14,2,'Disappointed, expected more!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(14,11,'I loved every second of it!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(15,5,'The best!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(15,8,'Great movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(15,9,'In love with this movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(15,7,'Could be better!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(15,11,'Diappointed!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(16,7,'Could be better!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(16,9,'Such a good movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(16,11,'Grat movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(16,8,'The best movie of all the time!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(16,1,'Could be better!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(17,6,'Good movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(17,3,'Such a good movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(17,2,'I expected more!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(17,11,'Great movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(17,13,'The best movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(18,9,'Such a good movie!!!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(18,5,'I loved it!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(18,11,'Great movie!!!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(18,13,'The best movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(18,6,'Disappointed, expected more!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(19,7,'The bestt!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(19,11,'In love with this movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(19,5,'Could be better!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(19,8,'Disappointed, could be better!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(19,10,'Great movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(20,4,'Just WOW!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(20,7,'The best of all the time!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(20,2,'I loved every second of it!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(20,9,'I can watch it over and over again!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(20,6,'Great movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(21,1,'The best!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(21,8,'The best movie of all the time!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(21,3,'The greatest!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(21,11,'Could be better!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(21,6,'Such a good movie!!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(22,6,'The Terminator is one of the greatest movies ever!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(22,8,'The best movie of all the time!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(22,3,'Expected more, after so many suggestions I got for this movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(22,9,'The best movie!')");

            migrationBuilder.Sql("INSERT INTO MovieComments(MovieId,UserId,Comment) VALUES" +
             "(22,12,'The greatest movie of all the time!')");
        }




        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }


    }
}
