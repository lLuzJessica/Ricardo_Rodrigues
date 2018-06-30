CREATE DATABASE IF NOT EXISTS db_prova_liax_ricardo_tarozo  DEFAULT CHARACTER SET utf8;
	
Use db_prova_liax_ricardo_tarozo;

CREATE TABLE IF NOT EXISTS `db_prova_liax_ricardo_tarozo`.`aluno` (
  `aluno_id` MEDIUMINT(8) UNSIGNED AUTO_INCREMENT,
  `aluno_nome` VARCHAR(50) NOT NULL,
  `idade` INT NOT NULL,
  `nome_pai` VARCHAR(50) NULL,
  `nome_mae` VARCHAR(50) NOT NULL,
  `numero_contrato` CHAR(15) NOT NULL,
  PRIMARY KEY (`aluno_id`),
  UNIQUE INDEX `aluno_id_UNIQUE` (`aluno_id` ASC));
  
 CREATE TABLE IF NOT EXISTS `db_prova_liax_ricardo_tarozo`.`diciplina` (
  `disciplina_codigo` CHAR(5) NOT NULL,
  `disciplina_nome` VARCHAR(20) NOT NULL,
  `data_inicial` DATE NOT NULL,
  `data_final` DATE NULL,
  `ementa` VARCHAR(256) NOT NULL,
  PRIMARY KEY (`disciplina_codigo`),
  UNIQUE INDEX `disciplina_codigo_UNIQUE` (`disciplina_codigo` ASC)); 
  
  CREATE TABLE IF NOT EXISTS `db_prova_liax_ricardo_tarozo`.`aluno_x_disciplina` (
  `aluno_id` MEDIUMINT(8) UNSIGNED NOT NULL,
  `disciplina_codigo` CHAR(5) NOT NULL,
  INDEX `fk_aluno_idx` (`aluno_id` ASC),
  INDEX `fk_disciplina_idx` (`disciplina_codigo` ASC),
  PRIMARY KEY (`aluno_id`, `disciplina_codigo`),
  CONSTRAINT `fk_aluno`
    FOREIGN KEY (`aluno_id`)
    REFERENCES `db_prova_liax_ricardo_tarozo`.`aluno` (`aluno_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_disciplina`
    FOREIGN KEY (`disciplina_codigo`)
    REFERENCES `db_prova_liax_ricardo_tarozo`.`diciplina` (`disciplina_codigo`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
