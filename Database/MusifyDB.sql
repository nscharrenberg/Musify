-- SQL Create script made by Noah Scharrenberg
-- 03/17/2017
-- Application: Musify
-- Software Engineering 2 - Fundamentals Killerapp
--

-- -----------------------------------------------------
-- Table User
-- -----------------------------------------------------
CREATE TABLE [Users] (
  [id] INT IDENTITY,
  [firstname] varchar(100) NOT NULL,
  [lastname] varchar(100) NOT null,
  [gender] varchar(10),
  [email] varchar(255) NOT NULL,
  [password] varchar(255) NOT NULL,
  [avatar_url] varchar(255) NOT NULL,
  [permissions] TEXT NOT NULL,
  [created_at] DATETIME NOT NULL,
  [updated_at] DATETIME,
  [paid] tinyint NOT NULL,
  [last_paid] DATETIME NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT unique_user_email UNIQUE ([email] ASC)
);

-- -----------------------------------------------------
-- Table Genre
-- -----------------------------------------------------
CREATE TABLE [Genre] (
  [id] INT IDENTITY,
  [name] varchar(100) NOT NULL,
  [description] TEXT NOT NULL,
  [image_url] varchar(255) NOT NULL,
  [created_at] DATETIME NOT NULL,
  [updated_at] DATETIME,
  PRIMARY KEY ([id])
);

-- -----------------------------------------------------
-- Table Artist
-- -----------------------------------------------------
CREATE TABLE [Artist] (
  [id] INT IDENTITY,
  [name] varchar(255) NOT NULL,
  [image_big_url] varchar(255) NOT NULL,
  [image_small_url] varchar(255) NOT NULL,
  [BIO] TEXT,
  [created_at] DATETIME NOT NULL,
  [updated_at] DATETIME,
  PRIMARY KEY ([id]),
  CONSTRAINT unique_artist_name UNIQUE([name] ASC)
);

-- -----------------------------------------------------
-- Table Playlist
-- -----------------------------------------------------
CREATE TABLE [Playlist] (
  [id] INT IDENTITY,
  [name] varchar(255) NOT NULL,
  [public] tinyint NOT NULL,
  [image_url] varchar(255),
  [description] TEXT,
  [created_at] DATETIME,
  [updated_at] DATETIME,
  PRIMARY KEY ([id]),
);

-- -----------------------------------------------------
-- Table ALbum
-- -----------------------------------------------------
CREATE TABLE [Album] (
  [id] INT IDENTITY,
  [name] varchar(255),
  [release_date] DATETIME,
  [img_big_url] varchar(255),
  [img_small_url] varchar(255),
  [artist_id] INT NOT NULL,
  PRIMARY KEY ([id], [artist_id]),
  CONSTRAINT fk_alb_artist_id FOREIGN KEY (artist_id) REFERENCES Users([id])
);

-- -----------------------------------------------------
-- Table Song
-- -----------------------------------------------------
CREATE TABLE [Song] (
  [id] INT IDENTITY,
  [name] varchar(255),
  [number] int,
  [duration] int,
  [youtube_url] varchar(255),
  [soundcloud_url] varchar(255),
  [server_url] varchar(255),
  [album_id] INT,
  [album_artist_id] INT,
  PRIMARY KEY ([id], [album_id], [album_artist_id]),
  CONSTRAINT fk_tr_album_id FOREIGN KEY (album_id) REFERENCES Album([id]),
  CONSTRAINT fk_tr_album_artist_id FOREIGN KEY (album_artist_id) REFERENCES Album([id])
);

-- -----------------------------------------------------
-- Table Song_User
-- -----------------------------------------------------
CREATE TABLE [Song_User] (
  [created_at] DATETIME,
  [user_id] INT,
  [song_id] INT,
  PRIMARY KEY ([user_id], [song_id]),
  CONSTRAINT fk_tu_user_id FOREIGN KEY (user_id) REFERENCES Users([id]),
  CONSTRAINT fk_tu_song_id FOREIGN KEY (song_id) REFERENCES Song([id])
);

-- -----------------------------------------------------
-- Table Genre_Artist
-- -----------------------------------------------------
CREATE TABLE [Genre_Artist] (
  [created_at] DATETIME,
  [genre_id] INT,
  [artist_id] INT,
  PRIMARY KEY ([genre_id], [artist_id]),
  CONSTRAINT fk_ga_genre_id FOREIGN KEY (genre_id) REFERENCES Genre([id]),
  CONSTRAINT fk_ga_artist_id FOREIGN KEY (artist_id) REFERENCES Artist([id])
);

-- -----------------------------------------------------
-- Table Playlist_User
-- -----------------------------------------------------
CREATE TABLE [Playlist_User] (
  [owner] tinyint,
  [playlist_id] INT,
  [user_id] INT,
  PRIMARY KEY ([playlist_id], [user_id]),
  CONSTRAINT fk_pu_playlist_id FOREIGN KEY (playlist_id) REFERENCES Playlist([id]),
  CONSTRAINT fk_pu_user_id FOREIGN KEY (user_id) REFERENCES Users([id])
);

-- -----------------------------------------------------
-- Table Playlist_Song
-- -----------------------------------------------------
CREATE TABLE [Playlist_Song] (
  [playlist_id] INT,
  [song_id] INT,
  [position] INT,
  PRIMARY KEY (playlist_id], [song_id]),
  CONSTRAINT fk_pt_playlist_id FOREIGN KEY (playlist_id) REFERENCES Playlist([id]),
  CONSTRAINT fk_pt_song_id FOREIGN KEY (song_id) REFERENCES Song([id])
);

-- -----------------------------------------------------
-- Table Simliar_Artist
-- -----------------------------------------------------
CREATE TABLE [Similar_Artist] (
  [similar_id] INT,
  [artist_id] INT,
  PRIMARY KEY ([similar_id], [artist_id]),
  CONSTRAINT fk_sa_similar_id FOREIGN KEY (similar_id) REFERENCES Artist([id]),
  CONSTRAINT fk_sa_artist_id FOREIGN KEY (artist_id) REFERENCES Artist([id])
);

-- -----------------------------------------------------
-- Table Follow
-- -----------------------------------------------------
CREATE TABLE [Follow] (
  [follower_id] INT,
  [followed_id] INT,
  [created_at] DATETIME
  PRIMARY KEY ([follower_id], [followed_id])
  CONSTRAINT fk_fol_follower_id FOREIGN KEY (follower_id) REFERENCES Users([id]),
  CONSTRAINT fk_fol_followed_id FOREIGN KEY (followed_id) REFERENCES Users([id])
);

-- -----------------------------------------------------
-- Table Featured Artists
-- -----------------------------------------------------
CREATE TABLE [Featured] (
[artist_id] INT,
[song_id] INT,
PRIMARY KEY ([artist_id], [song_id]),
CONSTRAINT fk_fa_artist_id FOREIGN KEY (artist_id) REFERENCES Artist([id]),
CONSTRAINT fk_fa_song_id FOREIGN KEY (song_id) REFERENCES Song([id])
);
