/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 100130
 Source Host           : localhost:3306
 Source Schema         : db_dvd

 Target Server Type    : MySQL
 Target Server Version : 100130
 File Encoding         : 65001

 Date: 23/06/2018 19:20:32
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tb_customer
-- ----------------------------
DROP TABLE IF EXISTS `tb_customer`;
CREATE TABLE `tb_customer`  (
  `id_cust` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_customer',
  `nama_cust` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'nama pembeli',
  `username` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'username pembeli yang dapat digunakan untuk log in',
  `email` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'email pembeli yang dapat digunakan untuk log in',
  `password` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'password pembeli yang digunakan untuk log in',
  PRIMARY KEY (`id_cust`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_customer
-- ----------------------------
INSERT INTO `tb_customer` VALUES (1, 'Ammar A', 'Ammar', 'ammar@gmail.com', 'ammara123');
INSERT INTO `tb_customer` VALUES (2, 'IGN Agung AAW', 'Agung', 'ignagung@gmail.com', 'qwerty');
INSERT INTO `tb_customer` VALUES (3, 'Reyhan Fikri', 'Reyhan', 'reyhanf@gmail.com', '000001');
INSERT INTO `tb_customer` VALUES (4, 'Rifky Syswanto', 'Rifky', 'rifkysyswanto@gmail.com', '0258');
INSERT INTO `tb_customer` VALUES (5, 'Andy Batary FN', 'Tary', 'tary@gmail.com', '14789632');
INSERT INTO `tb_customer` VALUES (6, 'Winda Mauli', 'winda', 'windamk@gmail.com', 'wndmk');
INSERT INTO `tb_customer` VALUES (7, 'Muhammad Budi', 'Budi', 'mbudi@gmail.com', 'budi444');
INSERT INTO `tb_customer` VALUES (8, 'Ahmad Asep', 'Ahmad', 'aasep@gmail.com', '11111');
INSERT INTO `tb_customer` VALUES (9, 'Siti Hawa', 'siha', 'sihawa@gmail.com', 'sihaaaa');
INSERT INTO `tb_customer` VALUES (10, 'Nur Intan', 'Intan', 'nintan@gmail.com', 'intan101');

-- ----------------------------
-- Table structure for tb_detail_keranjang
-- ----------------------------
DROP TABLE IF EXISTS `tb_detail_keranjang`;
CREATE TABLE `tb_detail_keranjang`  (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_detail_keranjang',
  `id_keranjang` int(11) NOT NULL COMMENT 'menghubungkan data dengan tabel tb_keranjang',
  `id_dvd` int(11) NOT NULL COMMENT 'menghubungkan data dengan tabel tb_dvd',
  `qty` int(11) NOT NULL COMMENT 'jumlah dvd yang dibeli',
  `harga_jual` int(11) NOT NULL COMMENT 'Harga kenyataan yang dijual ke pembeli',
  `total_harga` int(11) NOT NULL COMMENT 'Total harga dvd yang dibeli',
  PRIMARY KEY (`id_detail`) USING BTREE,
  INDEX `id_keranjang`(`id_keranjang`) USING BTREE,
  INDEX `id_dvd`(`id_dvd`) USING BTREE,
  CONSTRAINT `tb_detail_keranjang_ibfk_1` FOREIGN KEY (`id_keranjang`) REFERENCES `tb_keranjang` (`id_keranjang`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `tb_detail_keranjang_ibfk_2` FOREIGN KEY (`id_dvd`) REFERENCES `tb_dvd` (`id_dvd`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 20 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_detail_keranjang
-- ----------------------------
INSERT INTO `tb_detail_keranjang` VALUES (1, 1, 1, 1, 52000, 52000);
INSERT INTO `tb_detail_keranjang` VALUES (2, 2, 2, 1, 50000, 50000);
INSERT INTO `tb_detail_keranjang` VALUES (3, 3, 3, 2, 65000, 130000);
INSERT INTO `tb_detail_keranjang` VALUES (4, 4, 4, 1, 55000, 55000);
INSERT INTO `tb_detail_keranjang` VALUES (5, 5, 10, 3, 55000, 165000);
INSERT INTO `tb_detail_keranjang` VALUES (6, 6, 13, 2, 40000, 80000);
INSERT INTO `tb_detail_keranjang` VALUES (7, 7, 7, 1, 55000, 55000);
INSERT INTO `tb_detail_keranjang` VALUES (8, 8, 17, 2, 63500, 127000);
INSERT INTO `tb_detail_keranjang` VALUES (9, 9, 11, 4, 55000, 220000);
INSERT INTO `tb_detail_keranjang` VALUES (10, 10, 14, 1, 60000, 60000);
INSERT INTO `tb_detail_keranjang` VALUES (11, 11, 8, 1, 60000, 60000);
INSERT INTO `tb_detail_keranjang` VALUES (12, 12, 9, 2, 54000, 108000);
INSERT INTO `tb_detail_keranjang` VALUES (13, 13, 18, 5, 64500, 322500);
INSERT INTO `tb_detail_keranjang` VALUES (14, 14, 20, 1, 52500, 52500);
INSERT INTO `tb_detail_keranjang` VALUES (15, 15, 17, 63500, 2, 127000);
INSERT INTO `tb_detail_keranjang` VALUES (16, 1, 3, 1, 65000, 65000);
INSERT INTO `tb_detail_keranjang` VALUES (17, 1, 13, 13, 40000, 520000);
INSERT INTO `tb_detail_keranjang` VALUES (18, 1, 2, 3, 50000, 150000);
INSERT INTO `tb_detail_keranjang` VALUES (19, 3, 8, 2, 60000, 120000);

-- ----------------------------
-- Table structure for tb_dictionary
-- ----------------------------
DROP TABLE IF EXISTS `tb_dictionary`;
CREATE TABLE `tb_dictionary`  (
  `id_dictionary` int(11) NOT NULL,
  `nama_tabel` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `atribut_tabel` varchar(300) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_dictionary
-- ----------------------------
INSERT INTO `tb_dictionary` VALUES (1, 'tb_customer', 'id_cust int, nama_cust varchar(100), username varchar(100), email varchar(100), password varchar(100)');
INSERT INTO `tb_dictionary` VALUES (2, 'tb_detail_keranjang', 'id_detail int, id_keranjang int, id_dvd int, qty int, harga_jual int, total_harga int');
INSERT INTO `tb_dictionary` VALUES (3, 'tb_dvd', 'id_dvd int, id_movie int, stock int, harga_display int');
INSERT INTO `tb_dictionary` VALUES (4, 'tb_gambar_dvd', 'id_gambar int, id_dvd int, id_movie int, url_gambar varchar(200)');
INSERT INTO `tb_dictionary` VALUES (5, 'tb_genre', 'id_genre int, genre varchar(50)');
INSERT INTO `tb_dictionary` VALUES (6, 'tb_keranjang', 'id_keranjang int, id_cust int');
INSERT INTO `tb_dictionary` VALUES (7, 'tb_movie', 'id_movie int, id_genre int, judul varchar(150), tahun_produksi int, durasi int, rating_imdb decimal, rated varchar(10), bahasa varchar(50), subtitle varchar(50)');

-- ----------------------------
-- Table structure for tb_dvd
-- ----------------------------
DROP TABLE IF EXISTS `tb_dvd`;
CREATE TABLE `tb_dvd`  (
  `id_dvd` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_dvd',
  `id_movie` int(11) NOT NULL COMMENT 'menghubungkan data dengan tabel tb_movie',
  `stock` int(11) NOT NULL COMMENT 'Informasi mengenai jumlah stock dvd yang tersedia',
  `harga_display` int(11) NOT NULL COMMENT 'informasi mengenai harga yang ada di display',
  PRIMARY KEY (`id_dvd`) USING BTREE,
  INDEX `id_movie`(`id_movie`) USING BTREE,
  CONSTRAINT `tb_dvd_ibfk_1` FOREIGN KEY (`id_movie`) REFERENCES `tb_movie` (`id_movie`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_dvd
-- ----------------------------
INSERT INTO `tb_dvd` VALUES (1, 1, 10, 52000);
INSERT INTO `tb_dvd` VALUES (2, 2, 12, 50000);
INSERT INTO `tb_dvd` VALUES (3, 3, 5, 65000);
INSERT INTO `tb_dvd` VALUES (4, 4, 5, 55000);
INSERT INTO `tb_dvd` VALUES (5, 5, 15, 66000);
INSERT INTO `tb_dvd` VALUES (6, 6, 8, 62000);
INSERT INTO `tb_dvd` VALUES (7, 7, 10, 55000);
INSERT INTO `tb_dvd` VALUES (8, 8, 5, 60000);
INSERT INTO `tb_dvd` VALUES (9, 9, 7, 54000);
INSERT INTO `tb_dvd` VALUES (10, 10, 2, 80000);
INSERT INTO `tb_dvd` VALUES (11, 11, 5, 60000);
INSERT INTO `tb_dvd` VALUES (12, 12, 3, 75000);
INSERT INTO `tb_dvd` VALUES (13, 13, 6, 40000);
INSERT INTO `tb_dvd` VALUES (14, 14, 10, 60000);
INSERT INTO `tb_dvd` VALUES (15, 15, 8, 65000);
INSERT INTO `tb_dvd` VALUES (16, 16, 4, 40000);
INSERT INTO `tb_dvd` VALUES (17, 17, 6, 63500);
INSERT INTO `tb_dvd` VALUES (18, 18, 15, 64500);
INSERT INTO `tb_dvd` VALUES (19, 19, 4, 53400);
INSERT INTO `tb_dvd` VALUES (20, 20, 8, 52500);

-- ----------------------------
-- Table structure for tb_gambar_dvd
-- ----------------------------
DROP TABLE IF EXISTS `tb_gambar_dvd`;
CREATE TABLE `tb_gambar_dvd`  (
  `id_gambar` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_gambar_dvd',
  `id_dvd` int(11) NOT NULL COMMENT 'menghubungkan data yang ada di tabel tb_dvd',
  `id_movie` int(11) NOT NULL,
  `url_gambar` varchar(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'url gambar dvd',
  PRIMARY KEY (`id_gambar`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_gambar_dvd
-- ----------------------------
INSERT INTO `tb_gambar_dvd` VALUES (1, 1, 1, 'https://upload.wikimedia.org/wikipedia/id/b/be/Thor_Ragnarok_poster_2.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (2, 2, 2, 'https://upload.wikimedia.org/wikipedia/id/e/ed/Wonder_Woman_%282017_film%29.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (3, 3, 3, 'https://upload.wikimedia.org/wikipedia/id/d/d7/Coco_%282017_film%29_logo.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (4, 4, 4, 'https://upload.wikimedia.org/wikipedia/id/7/7d/The_Post_Steven_Spielberg_Poster_2017.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (5, 5, 5, 'https://upload.wikimedia.org/wikipedia/id/d/d6/Beauty_and_the_Beast_2017_poster.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (6, 6, 6, 'https://upload.wikimedia.org/wikipedia/id/6/65/IT_Bill_Skarsgard_Poster_2017.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (7, 7, 7, 'https://upload.wikimedia.org/wikipedia/id/2/2a/LOTRTTTmovie.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (8, 8, 8, 'https://upload.wikimedia.org/wikipedia/id/8/8a/Dark_Knight.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (9, 9, 9, 'https://upload.wikimedia.org/wikipedia/id/4/4d/Catch_Me_If_You_Can_2002_movie.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (10, 10, 10, 'https://upload.wikimedia.org/wikipedia/id/8/87/StarWarsMoviePoster1977.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (11, 11, 11, 'https://upload.wikimedia.org/wikipedia/id/9/91/Inception_poster.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (12, 12, 12, 'https://upload.wikimedia.org/wikipedia/id/4/4b/Titanic_film.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (13, 13, 13, 'https://upload.wikimedia.org/wikipedia/id/1/1c/Nemo-poster2.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (14, 14, 14, 'https://upload.wikimedia.org/wikipedia/id/1/17/Laskar_Pelangi_film.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (15, 15, 15, 'https://upload.wikimedia.org/wikipedia/id/7/74/Habibie_Ainun_Poster.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (16, 16, 16, 'https://upload.wikimedia.org/wikipedia/id/e/ed/The_Raid_Poster.JPG');
INSERT INTO `tb_gambar_dvd` VALUES (17, 17, 17, 'https://upload.wikimedia.org/wikipedia/id/4/4c/Miracle_in_Cell_No_7_poster.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (18, 18, 18, 'https://upload.wikimedia.org/wikipedia/id/9/95/Train_to_Busan.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (19, 19, 19, 'https://upload.wikimedia.org/wikipedia/id/e/e3/Secretly_Greatly_poster.jpg');
INSERT INTO `tb_gambar_dvd` VALUES (20, 20, 20, 'https://upload.wikimedia.org/wikipedia/id/b/be/Hachi_poster.jpg');

-- ----------------------------
-- Table structure for tb_genre
-- ----------------------------
DROP TABLE IF EXISTS `tb_genre`;
CREATE TABLE `tb_genre`  (
  `id_genre` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_genre',
  `genre` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'genre pada setiap filmnya',
  PRIMARY KEY (`id_genre`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_genre
-- ----------------------------
INSERT INTO `tb_genre` VALUES (1, 'Action');
INSERT INTO `tb_genre` VALUES (2, 'Adventure');
INSERT INTO `tb_genre` VALUES (3, 'Comedy');
INSERT INTO `tb_genre` VALUES (4, 'Crime');
INSERT INTO `tb_genre` VALUES (5, 'Drama');
INSERT INTO `tb_genre` VALUES (6, 'Fantasy');
INSERT INTO `tb_genre` VALUES (7, 'Historical');
INSERT INTO `tb_genre` VALUES (8, 'Horror');
INSERT INTO `tb_genre` VALUES (9, 'Mystery');
INSERT INTO `tb_genre` VALUES (10, 'Romance');
INSERT INTO `tb_genre` VALUES (11, 'Saga');
INSERT INTO `tb_genre` VALUES (12, 'Science Fiction');
INSERT INTO `tb_genre` VALUES (13, 'Thriller ');
INSERT INTO `tb_genre` VALUES (14, 'Western');

-- ----------------------------
-- Table structure for tb_keranjang
-- ----------------------------
DROP TABLE IF EXISTS `tb_keranjang`;
CREATE TABLE `tb_keranjang`  (
  `id_keranjang` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_keranjang',
  `id_cust` int(11) NOT NULL COMMENT 'menghubungkan data yang ada di tabel tb_custoomer',
  PRIMARY KEY (`id_keranjang`) USING BTREE,
  INDEX `id_cust`(`id_cust`) USING BTREE,
  CONSTRAINT `tb_keranjang_ibfk_1` FOREIGN KEY (`id_cust`) REFERENCES `tb_customer` (`id_cust`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 16 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_keranjang
-- ----------------------------
INSERT INTO `tb_keranjang` VALUES (1, 1);
INSERT INTO `tb_keranjang` VALUES (2, 1);
INSERT INTO `tb_keranjang` VALUES (3, 2);
INSERT INTO `tb_keranjang` VALUES (4, 3);
INSERT INTO `tb_keranjang` VALUES (5, 4);
INSERT INTO `tb_keranjang` VALUES (6, 4);
INSERT INTO `tb_keranjang` VALUES (7, 5);
INSERT INTO `tb_keranjang` VALUES (8, 6);
INSERT INTO `tb_keranjang` VALUES (9, 7);
INSERT INTO `tb_keranjang` VALUES (10, 7);
INSERT INTO `tb_keranjang` VALUES (11, 8);
INSERT INTO `tb_keranjang` VALUES (12, 9);
INSERT INTO `tb_keranjang` VALUES (13, 9);
INSERT INTO `tb_keranjang` VALUES (14, 10);
INSERT INTO `tb_keranjang` VALUES (15, 10);

-- ----------------------------
-- Table structure for tb_movie
-- ----------------------------
DROP TABLE IF EXISTS `tb_movie`;
CREATE TABLE `tb_movie`  (
  `id_movie` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id primary key untuk tabel tb_movie',
  `id_genre` int(11) NOT NULL COMMENT 'menghubungkana data yang ada di tabel tb_genre',
  `judul` varchar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'judul pada setiap filmnya',
  `tahun_produksi` int(4) NOT NULL COMMENT 'tahun film tersebut tayang ',
  `durasi` int(11) NOT NULL COMMENT 'lama film tayang (dalam menit)',
  `rating_imdb` decimal(10, 1) NOT NULL COMMENT 'rating yang diambil dari imdb',
  `rated` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'menunjukan film tersebut layak ditonton untuk kalangan usia berapa saja',
  `bahasa` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'bahasa yang digunakan di film',
  `subtitle` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL COMMENT 'subtitle yang tersedia dalam bahasa apa saja',
  PRIMARY KEY (`id_movie`) USING BTREE,
  INDEX `id_genre`(`id_genre`) USING BTREE,
  CONSTRAINT `tb_movie_ibfk_1` FOREIGN KEY (`id_genre`) REFERENCES `tb_genre` (`id_genre`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tb_movie
-- ----------------------------
INSERT INTO `tb_movie` VALUES (1, 1, 'Thor: Ragnarok', 2017, 130, 7.9, 'PG-13', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (2, 1, 'Wonder Woman', 2017, 141, 7.5, 'PG-13', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (3, 3, 'Coco', 2017, 105, 8.5, 'PG', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (4, 7, 'The Post', 2017, 116, 7.2, 'PG-13', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (5, 10, 'Beauty and the Beast', 2017, 129, 7.2, 'PG', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (6, 8, 'It', 2017, 135, 7.5, 'R', 'English', 'English');
INSERT INTO `tb_movie` VALUES (7, 2, 'The Lord of the Rings: The Two Towers', 2002, 179, 8.7, 'PG-13', 'English', 'English');
INSERT INTO `tb_movie` VALUES (8, 4, 'The Dark Knight', 2008, 152, 9.0, 'PG-13', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (9, 4, 'Catch Me If You Can', 2002, 141, 8.1, 'PG-13', 'English', 'English');
INSERT INTO `tb_movie` VALUES (10, 6, 'Star Wars: Episode IV - A New Hope', 1977, 121, 8.6, 'PG-13', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (11, 1, 'Inception', 2010, 148, 8.8, 'PG-13', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (12, 10, 'Titanic', 1997, 194, 7.8, 'PG-13', 'English', 'Indonesia');
INSERT INTO `tb_movie` VALUES (13, 2, 'Finding Nemo', 2003, 100, 8.1, 'G', 'English ', 'Indonesia');
INSERT INTO `tb_movie` VALUES (14, 5, 'Laskar Pelangi', 2008, 124, 7.8, 'PG-13', 'Indonesia', '');
INSERT INTO `tb_movie` VALUES (15, 5, 'Habibie & Ainun', 2012, 120, 7.6, 'PG-13', 'Indonesia', '');
INSERT INTO `tb_movie` VALUES (16, 1, 'The Raid: Redemption', 2011, 101, 7.6, 'R', 'Indonesia', 'English');
INSERT INTO `tb_movie` VALUES (17, 5, 'Miracle in Cell No. 7', 2013, 127, 8.2, 'PG-13', 'Korea', 'Indonesia');
INSERT INTO `tb_movie` VALUES (18, 13, 'Train to Busan', 2016, 118, 7.5, 'PG-13', 'Korea', 'English');
INSERT INTO `tb_movie` VALUES (19, 5, 'Secretly, Greatly', 2013, 124, 6.9, 'R', 'Korea', 'English');
INSERT INTO `tb_movie` VALUES (20, 5, 'Hachi: A Dog\'s Tale', 2009, 99, 8.1, 'G', 'Japan', 'English');

SET FOREIGN_KEY_CHECKS = 1;
