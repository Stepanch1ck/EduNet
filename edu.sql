-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Мар 30 2024 г., 13:40
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
-- База данных: `edu`
--

-- --------------------------------------------------------

--
-- Структура таблицы `admin`
--

CREATE TABLE `admin` (
  `ID` int(11) NOT NULL,
  `Surname` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Patronomyc` varchar(50) NOT NULL,
  `ProfilePicture` polygon DEFAULT NULL,
  `Group` int(5) NOT NULL,
  `Login` varchar(32) NOT NULL,
  `Password` varchar(32) NOT NULL,
  `Subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `admin`
--

INSERT INTO `admin` (`ID`, `Surname`, `Name`, `Patronomyc`, `ProfilePicture`, `Group`, `Login`, `Password`, `Subject`) VALUES
(1, 'Бродовская', 'Людмила', 'Николаевна', NULL, 321, 'люда', '3645', 'История'),
(2, 'Латыпова', 'Дина', 'Сергеевна', NULL, 321, 'дина', '6830', 'Разработка приложений на си шарп');

-- --------------------------------------------------------

--
-- Структура таблицы `exam`
--

CREATE TABLE `exam` (
  `ID` int(11) NOT NULL,
  `Subject` varchar(50) NOT NULL,
  `Score1Sem` int(11) NOT NULL,
  `Score2Sem` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `lesson`
--

CREATE TABLE `lesson` (
  `ID` int(11) NOT NULL,
  `WeekDay` varchar(20) NOT NULL,
  `NumberOfLesson` int(2) NOT NULL,
  `Time` time(6) NOT NULL,
  `EndTime` time(6) NOT NULL,
  `Subject` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `lesson`
--

INSERT INTO `lesson` (`ID`, `WeekDay`, `NumberOfLesson`, `Time`, `EndTime`, `Subject`) VALUES
(1, 'Понедельник', 1, '08:30:00.000000', '10:10:00.000000', 'Математический анализ'),
(2, 'Понедельник', 2, '10:10:00.000000', '11:40:00.000000', 'Английский язык'),
(3, 'Понедельник', 3, '12:10:00.000000', '13:40:00.000000', 'История'),
(4, 'Вторник', 2, '10:10:00.000000', '11:40:00.000000', 'Физическая культура'),
(5, 'Среда', 1, '08:30:00.000000', '10:00:00.000000', 'Основы права и противодействия коррупции'),
(6, 'Среда', 2, '10:10:00.000000', '11:40:00.000000', 'null'),
(7, 'Среда', 3, '12:10:00.000000', '13:40:00.000000', 'Математический анализ'),
(8, 'Среда', 4, '13:50:00.000000', '15:20:00.000000', 'Алгебра и геометрия'),
(9, 'Четверг', 2, '10:10:00.000000', '11:40:00.000000', 'Русский язык'),
(10, 'Пятница', 3, '12:10:00.000000', '13:40:00.000000', 'История'),
(11, 'Суббота', 2, '10:30:00.000000', '12:00:00.000000', 'Разработка приложений на c#');

-- --------------------------------------------------------

--
-- Структура таблицы `performance`
--

CREATE TABLE `performance` (
  `ID` int(11) NOT NULL,
  `Subject` varchar(50) NOT NULL,
  `Score1Sem` int(11) DEFAULT NULL,
  `Score2Sem` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `performance`
--

INSERT INTO `performance` (`ID`, `Subject`, `Score1Sem`, `Score2Sem`) VALUES
(1, 'Математический анализ', 37, 43),
(2, 'Английский язык', 45, 45),
(3, 'История', 28, 35),
(4, 'Алгебра и геометрия', 24, 30),
(5, 'Разработка приложений на c#', 28, 30),
(6, 'Русский язык', 28, 42);

-- --------------------------------------------------------

--
-- Структура таблицы `schedule`
--

CREATE TABLE `schedule` (
  `ID` int(11) NOT NULL,
  `Lesson` int(11) NOT NULL,
  `Exam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `student`
--

CREATE TABLE `student` (
  `ID` int(11) NOT NULL,
  `Surname` varchar(50) NOT NULL,
  `Name` text NOT NULL,
  `Patronomyc` varchar(50) NOT NULL,
  `ProfilePicture` polygon DEFAULT NULL,
  `Group` int(5) NOT NULL,
  `Login` varchar(32) NOT NULL,
  `Password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `student`
--

INSERT INTO `student` (`ID`, `Surname`, `Name`, `Patronomyc`, `ProfilePicture`, `Group`, `Login`, `Password`) VALUES
(1, 'щшгро', '0', 'Сергеевна', NULL, 321, 'админ', '1234'),
(2, 'Чуркин', 'Степан', 'Сергеевич', NULL, 321, 'стёпа', '5678'),
(3, 'Каримов', 'Адель', 'Ильдарович', NULL, 322, 'адель', '7890');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `exam`
--
ALTER TABLE `exam`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- Индексы таблицы `performance`
--
ALTER TABLE `performance`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- Индексы таблицы `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`Lesson`);

--
-- Индексы таблицы `student`
--
ALTER TABLE `student`
  ADD UNIQUE KEY `ID` (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `admin`
--
ALTER TABLE `admin`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `exam`
--
ALTER TABLE `exam`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `performance`
--
ALTER TABLE `performance`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `student`
--
ALTER TABLE `student`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
