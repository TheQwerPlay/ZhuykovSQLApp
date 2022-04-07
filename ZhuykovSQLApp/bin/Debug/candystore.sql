-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Апр 07 2022 г., 18:04
-- Версия сервера: 5.7.24
-- Версия PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `candystore`
--

-- --------------------------------------------------------

--
-- Структура таблицы `arrivallog`
--

CREATE TABLE `arrivallog` (
  `id_ArrivalLog` int(10) UNSIGNED NOT NULL,
  `date` datetime NOT NULL,
  `id_sweet` int(10) UNSIGNED NOT NULL,
  `count` int(10) UNSIGNED NOT NULL,
  `id_supplier` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `arrivallog`
--

INSERT INTO `arrivallog` (`id_ArrivalLog`, `date`, `id_sweet`, `count`, `id_supplier`) VALUES
(1, '2022-04-01 09:59:59', 2, 50, 2),
(2, '2022-04-01 09:59:59', 5, 12, 1),
(3, '2022-03-01 12:59:59', 2, 50, 3),
(4, '2022-02-01 09:59:59', 4, 44, 3),
(5, '2022-01-01 12:59:59', 6, 50, 2),
(6, '2022-05-01 12:59:59', 5, 27, 3);

-- --------------------------------------------------------

--
-- Структура таблицы `supplier`
--

CREATE TABLE `supplier` (
  `id_supplier` int(10) UNSIGNED NOT NULL,
  `supplier` varchar(100) NOT NULL,
  `phone` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `supplier`
--

INSERT INTO `supplier` (`id_supplier`, `supplier`, `phone`, `address`) VALUES
(1, 'Кондитерская фабрика «Торговый Дом Шоколада»', '8(495)575-34-00', 'квартал, Вашутино, владение 29 А, Химки, Московская обл., 141400'),
(2, 'ООО Кондитерская фабрика \"Shokolate', '8(495)22-600-60', 'Ломоносова, 3 в Калининграде'),
(3, 'Фабрика сладостей «Laycy Queen»', '8 (917) 433-13-18', 'улица Ленина, 8Б, Субханкулово, Респ. Башкортостан, 452778');

-- --------------------------------------------------------

--
-- Структура таблицы `sweets`
--

CREATE TABLE `sweets` (
  `id_sweet` int(10) UNSIGNED NOT NULL,
  `sweet` varchar(100) NOT NULL,
  `unitOfMeasure` varchar(100) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sweets`
--

INSERT INTO `sweets` (`id_sweet`, `sweet`, `unitOfMeasure`, `price`) VALUES
(1, 'Bounty', 'упаковка', 52),
(2, 'Snickers', 'упаковка', 62),
(3, 'Twix', 'коробка', 500),
(4, 'Золотой Степ', 'коробка', 258),
(5, 'Золотой Степ', 'упаковка', 43),
(6, 'Twix', 'упаковка', 50);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(10) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL,
  `name` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `pass`, `name`, `surname`) VALUES
(1, 'Admin', '123', '', ''),
(2, '123', '123', '', ''),
(3, 'bogdanzh@gmail.com', '123456', 'Богдан', 'Жуйков'),
(4, 'r_6_s@rambler.ru', '123', 'Андрей', 'Худынин'),
(5, 'gang@yandex.ru', '5643', 'Дмитрий', 'Орехов');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `arrivallog`
--
ALTER TABLE `arrivallog`
  ADD UNIQUE KEY `id` (`id_ArrivalLog`),
  ADD KEY `id_sweet` (`id_sweet`),
  ADD KEY `id_supplier` (`id_supplier`);

--
-- Индексы таблицы `supplier`
--
ALTER TABLE `supplier`
  ADD KEY `id_supplier` (`id_supplier`) USING BTREE;

--
-- Индексы таблицы `sweets`
--
ALTER TABLE `sweets`
  ADD KEY `id_sweet` (`id_sweet`) USING BTREE;

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `arrivallog`
--
ALTER TABLE `arrivallog`
  MODIFY `id_ArrivalLog` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id_supplier` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `sweets`
--
ALTER TABLE `sweets`
  MODIFY `id_sweet` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `arrivallog`
--
ALTER TABLE `arrivallog`
  ADD CONSTRAINT `arrivallog_ibfk_1` FOREIGN KEY (`id_sweet`) REFERENCES `sweets` (`id_sweet`),
  ADD CONSTRAINT `arrivallog_ibfk_2` FOREIGN KEY (`id_supplier`) REFERENCES `supplier` (`id_supplier`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
