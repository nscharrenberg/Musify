---
--- Users
---
CREATE TABLE [User] (
  [id] INT,
  [firstname] varchar(100),
  [lastname] varchar(100),
  [gender] varchar(10),
  [username] varchar(255),
  [email] varchar(255),
  [password] varchar(255),
  [avatar_url] varchar(255),
  [permissions] TEXT,
  [created_at] DATETIME,
  [updated_at] DATETIME,
  [paid] BIT,
  [last_paid] DATETIME,
  PRIMARY KEY ([id])
);
CREATE INDEX [N] ON  [User] ([gender], [avatar_url], [last_paid]);
CREATE INDEX [U] ON  [User] ([email]);

---
--- Follow
---
CREATE TABLE [follow] (
  [follower_id] INT,
  [followed_id] INT,
  [created_at] DATETIME
);
CREATE INDEX [FK, PK] ON  [follow] ([follower_id], [followed_id]);

---
--- Genre
---
CREATE TABLE [genre] (
  [id] INT,
  [name] varchar(100),
  [description] TEXT,
  [image_url] varchar(255),
  [created_at] DATETIME,
  [updated_at] DATETIME,
  PRIMARY KEY ([id])
);
CREATE INDEX [U] ON  [genre] ([name]);

---
--- Artist
---
CREATE TABLE [artist] (
  [id] INT,
  [name] varchar(255),
  [image_big_url] varchar(255),
  [image_small_url] varchar(255),
  [BIO] TEXT,
  [created_at] DATETIME,
  [updated_at] DATETIME,
  PRIMARY KEY ([id])
);
CREATE INDEX [N] ON  [artist] ([image_small_url]);

---
--- Album
---
CREATE TABLE [album] (
  [id] INT,
  [name] varchar(255),
  [release_date] DATETIME,
  [img_big_url] varchar(255),
  [img_small_url] varchar(255),
  [created_at] DATETIME,
  [updated_at] DATETIME,
  [artist_id] INT,
  PRIMARY KEY ([id])
);
CREATE INDEX [N] ON  [album] ([img_small_url]);
CREATE INDEX [FK] ON  [album] ([artist_id]);

---
--- Song
---
CREATE TABLE [Song] (
  [id] INT,
  [name] varchar(255),
  [number] INT,
  [duration] INT,
  [youtube_url] varchar(255),
  [soundcloud_url] varchar(255),
  [server_url] varchar(255),
  [album_id] INT,
  [album_artist_id] INT,
  PRIMARY KEY ([id])
);
CREATE INDEX [N] ON  [Song] ([number], [youtube_url], [soundcloud_url]);
CREATE INDEX [FK] ON  [Song] ([album_id], [album_artist_id]);

---
--- Genre_artist
---
CREATE TABLE [genre_artist] (
  [genre_id] INT,
  [artist_id] INT,
  [created_at] DATETIME
);
CREATE INDEX [FK, PK] ON  [genre_artist] ([genre_id], [artist_id]);

---
--- Featured Artists
---
CREATE TABLE [featured] (
  [artist_id] INT,
  [song_id] INT
);
CREATE INDEX [FK, PK] ON  [featured] ([artist_id], [song_id]);

---
--- Similar artists
---
CREATE TABLE [similar_artist] (
  [similar_id] INT,
  [artist_id] INT
);
CREATE INDEX [FK, PK] ON  [similar_artist] ([similar_id], [artist_id]);

---
--- song_user
---
CREATE TABLE [song_user] (
  [created_at] DATETIME,
  [user_id] INT,
  [song_id] INT
);
CREATE INDEX [FK, PK] ON  [song_user] ([user_id], [song_id]);


---
--- Playlist
---
CREATE TABLE [playlist] (
  [id] INT,
  [name] varchar(255),
  [public] BIT,
  [image_url] varchar(255),
  [description] TEXT,
  [created_at] DATETIME,
  [updated_at] DATETIME,
  PRIMARY KEY ([id])
);
CREATE INDEX [N] ON  [playlist] ([image_url]);

---
--- Playlist_User
---
CREATE TABLE [playlist_user] (
  [playlist_id] INT,
  [user_id] INT,
  [owner] BIT
);
CREATE INDEX [FK, PK] ON  [playlist_user] ([playlist_id], [user_id]);

---
--- Playlist_Song
---
CREATE TABLE [playlist_song] (
  [playlist_id] INT,
  [song_id] INT,
  [position] INT
);
CREATE INDEX [FK, PK] ON  [playlist_song] ([playlist_id], [song_id]);
CREATE INDEX [N] ON  [playlist_song] ([position]);






















