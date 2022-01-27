-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Jan-2022 às 23:02
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `super`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `candidatos`
--

CREATE TABLE `candidatos` (
  `idcandidato` int(9) NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `experiencia` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `candidatos`
--

INSERT INTO `candidatos` (`idcandidato`, `nome`, `experiencia`) VALUES
(1, 'JoÃ£o Paulo', 'Atendente de padaria'),
(2, 'Adamastor JÃºnior', 'Repositor'),
(3, 'Ana ClÃ¡udia', 'Atendente de caixa'),
(4, 'Daltron Silva', 'MecÃ¢nico de carros'),
(5, 'Tiel Evandro', 'Lavador de carros'),
(6, 'Amanda Carvalho', 'Atendente de caixa'),
(7, 'ClÃ³vis Nogueira', 'Atendente de padaria'),
(8, 'Jorge Pereira', 'Coveiro');

-- --------------------------------------------------------

--
-- Estrutura da tabela `consumidor`
--

CREATE TABLE `consumidor` (
  `IdConsumidor` int(11) NOT NULL,
  `tipoConsumidor` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `consumidor`
--

INSERT INTO `consumidor` (`IdConsumidor`, `tipoConsumidor`) VALUES
(1, 'consumidor final'),
(2, 'consumidor final'),
(3, 'consumidor final'),
(4, 'consumidor final'),
(5, 'consumidor final'),
(6, 'consumidor final'),
(7, 'consumidor final');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--

CREATE TABLE `fornecedores` (
  `idfornecedor` int(9) NOT NULL,
  `nomeProduto` varchar(200) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `quantidadeProduto` int(9) DEFAULT NULL,
  `setor` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `fornecedores`
--

INSERT INTO `fornecedores` (`idfornecedor`, `nomeProduto`, `valorProduto`, `quantidadeProduto`, `setor`) VALUES
(1, 'Leite integral', 2.00, 100, 'Padaria'),
(2, 'PÃ£o de manteiga', 3.50, 125, 'Padaria'),
(3, 'Manteiga', 5.99, 60, 'Padaria'),
(4, 'Doce de morango', 2.90, 50, 'Padaria'),
(5, 'Queijo fatiado', 18.90, 60, 'Padaria'),
(6, 'Desodorante', 8.99, 100, 'Perfumaria'),
(7, 'Xampu', 6.99, 200, 'Perfumaria'),
(8, 'Condicionador', 8.90, 50, 'Perfumaria'),
(9, 'Sabonete', 0.89, 500, 'Perfumaria'),
(10, 'Cotonete', 2.50, 100, 'Perfumaria'),
(11, 'Batata-branca', 1.90, 100, 'Hortifruti'),
(12, 'Tomate', 3.90, 58, 'Hortifruti'),
(13, 'Cebola roxa', 2.99, 50, 'Hortifruti'),
(14, 'AbÃ³bora', 0.98, 90, 'Hortifruti'),
(15, 'PimentÃ£o', 5.99, 60, 'Hortifruti'),
(16, 'Arroz', 2.50, 200, 'Alimentos'),
(17, 'FeijÃ£o', 3.69, 250, 'Alimentos'),
(18, 'Farinha', 2.19, 500, 'Alimentos'),
(19, 'AÃ§Ãºcar', 2.39, 100, 'Alimentos'),
(20, 'Ã“leo de soja', 2.99, 300, 'Alimentos');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `IdFuncionario` int(4) NOT NULL,
  `NomeFuncionario` varchar(200) DEFAULT NULL,
  `SetorFuncionario` varchar(80) DEFAULT NULL,
  `CPF` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`IdFuncionario`, `NomeFuncionario`, `SetorFuncionario`, `CPF`) VALUES
(1, 'JoÃ£o Paulo', 'Atendente de padaria', '33256987525'),
(2, 'ClÃ³vis Nogueira', 'Atendente de padaria', '45061690935'),
(3, 'Adamastor JÃºnior', 'Repositor', '09865880935'),
(4, 'Ana ClÃ¡udia', 'Atendente de caixa', '00235656565'),
(5, 'Amanda Carvalho', 'Atendente de caixa', '33256987525');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_vendidos`
--

CREATE TABLE `itens_vendidos` (
  `IdVenda` int(11) NOT NULL,
  `IdProduto` int(11) NOT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `ValorProduto` double(9,2) DEFAULT NULL,
  `ValorTotalProduto` double(9,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `itens_vendidos`
--

INSERT INTO `itens_vendidos` (`IdVenda`, `IdProduto`, `Quantidade`, `ValorProduto`, `ValorTotalProduto`) VALUES
(1, 2, 3, 7.18, 21.54),
(3, 1, 1, 2.40, 2.40),
(4, 5, 2, 3.58, 7.16),
(4, 7, 3, 2.28, 6.84),
(5, 3, 1, 10.68, 10.68);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `idProduto` int(11) NOT NULL,
  `nomeProduto` varchar(200) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `quantidadeProduto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`idProduto`, `nomeProduto`, `valorProduto`, `quantidadeProduto`) VALUES
(1, 'Leite integral', 2.40, 100),
(2, 'Manteiga', 7.18, 60),
(3, 'Condicionador', 10.68, 50),
(4, 'Farinha', 2.62, 500),
(5, 'Cebola roxa', 3.58, 50),
(6, 'Queijo fatiado', 22.68, 60),
(7, 'Batata-branca', 2.28, 100);

-- --------------------------------------------------------

--
-- Estrutura da tabela `selecionados`
--

CREATE TABLE `selecionados` (
  `idselecionado` int(9) NOT NULL,
  `idcandidato` int(11) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `selecionados`
--

INSERT INTO `selecionados` (`idselecionado`, `idcandidato`, `cpf`) VALUES
(1, 1, '00061690935'),
(2, 2, '45061690935'),
(3, 3, '09865880935'),
(4, 4, '12348956365'),
(5, 5, '88896532535'),
(6, 6, '33256987525'),
(7, 7, '00235656565'),
(8, 8, '77785545855');

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `IdVenda` int(11) NOT NULL,
  `IdConsumidor` int(11) DEFAULT NULL,
  `ValorTotalVenda` double(9,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`IdVenda`, `IdConsumidor`, `ValorTotalVenda`) VALUES
(1, 6, 3.00),
(3, 5, 2.00),
(4, 2, 10.00),
(5, 4, 8.00);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `candidatos`
--
ALTER TABLE `candidatos`
  ADD PRIMARY KEY (`idcandidato`);

--
-- Índices para tabela `consumidor`
--
ALTER TABLE `consumidor`
  ADD PRIMARY KEY (`IdConsumidor`);

--
-- Índices para tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD PRIMARY KEY (`idfornecedor`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`IdFuncionario`);

--
-- Índices para tabela `itens_vendidos`
--
ALTER TABLE `itens_vendidos`
  ADD PRIMARY KEY (`IdVenda`,`IdProduto`),
  ADD KEY `IdProduto` (`IdProduto`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`idProduto`);

--
-- Índices para tabela `selecionados`
--
ALTER TABLE `selecionados`
  ADD PRIMARY KEY (`idselecionado`),
  ADD KEY `candidatos` (`idcandidato`);

--
-- Índices para tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`IdVenda`),
  ADD KEY `IdConsumidor` (`IdConsumidor`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `candidatos`
--
ALTER TABLE `candidatos`
  MODIFY `idcandidato` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `consumidor`
--
ALTER TABLE `consumidor`
  MODIFY `IdConsumidor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  MODIFY `idfornecedor` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `IdFuncionario` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `idProduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `selecionados`
--
ALTER TABLE `selecionados`
  MODIFY `idselecionado` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `IdVenda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `itens_vendidos`
--
ALTER TABLE `itens_vendidos`
  ADD CONSTRAINT `itens_vendidos_ibfk_1` FOREIGN KEY (`IdVenda`) REFERENCES `venda` (`IdVenda`),
  ADD CONSTRAINT `itens_vendidos_ibfk_2` FOREIGN KEY (`IdProduto`) REFERENCES `produtos` (`idProduto`);

--
-- Limitadores para a tabela `selecionados`
--
ALTER TABLE `selecionados`
  ADD CONSTRAINT `candidatos` FOREIGN KEY (`idcandidato`) REFERENCES `candidatos` (`idcandidato`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`IdConsumidor`) REFERENCES `consumidor` (`IdConsumidor`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
