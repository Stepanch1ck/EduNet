-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Мар 28 2024 г., 10:54
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `schedule`
--

-- --------------------------------------------------------

--
-- Структура таблицы `schedule`
--

CREATE TABLE `schedule` (
  `ID` int(11) NOT NULL,
  `WeekDay` varchar(20) NOT NULL,
  `NumberOfLesson` int(2) NOT NULL,
  `Time` time(6) NOT NULL,
  `Subject` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `schedule`
--

INSERT INTO `schedule` (`ID`, `WeekDay`, `NumberOfLesson`, `Time`, `Subject`) VALUES
(1, 'Понедельник', 1, '08:30:00.000000', 'Математический анализ'),
(2, 'Понедельник', 2, '10:10:00.000000', 'Английский язык'),
(3, 'Понедельник', 3, '12:10:00.000000', 'История'),
(4, 'Вторник', 2, '10:10:00.000000', 'Физическая культура'),
(5, 'Среда', 1, '08:30:00.000000', 'Основы права и противодействия коррупции'),
(6, 'Среда', 2, '10:10:00.000000', NULL),
(7, 'Среда', 3, '12:10:00.000000', 'Математический анализ'),
(8, 'Среда', 4, '13:50:00.000000', 'Алгебра и геометрия'),
(9, 'Четверг', 2, '10:10:00.000000', 'Русский язык'),
(10, 'Пятница', 3, '12:10:00.000000', 'История'),
(11, 'Суббота', 2, '10:30:00.000000', 'Разработка приложений на c#'),
(12, 'Среда', 3, '08:30:00.000000', 'Основы права и противодействия коррупции');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
