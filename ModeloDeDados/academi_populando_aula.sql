USE `academiadb`;

-- Inserção das aulas
INSERT INTO aula (idaula, nome, descricao, data_horario_inicio, data_horario_fim, idinstrutor) VALUES
(1, 'Musculação', 'Treino completo', '2025-03-14 08:00:00', '2025-03-14 08:50:00', 1),
(2, 'Pilates', 'Pilates básico', '2025-03-14 09:00:00', '2025-03-14 09:50:00', 2),
(3, 'Yoga', 'Yoga intermediário', '2025-03-14 10:00:00', '2025-03-14 10:50:00', 3),
(4, 'Crossfit', 'Intensivo Crossfit', '2025-03-14 11:00:00', '2025-03-14 11:50:00', 4),
(5, 'Spinning', 'Aula spinning', '2025-03-14 12:00:00', '2025-03-14 12:50:00', 5);

-- Associação de alunos às aulas (2 alunos por aula)
INSERT INTO aluno_aula (aluno_idaluno, aula_idaula) VALUES
-- Aula 1
(1, 1), (2, 1),
-- Aula 2
(3, 2), (4, 2),
-- Aula 3
(5, 3), (6, 3),
-- Aula 4
(7, 4), (8, 4),
-- Aula 5
(9, 5), (10, 5);
