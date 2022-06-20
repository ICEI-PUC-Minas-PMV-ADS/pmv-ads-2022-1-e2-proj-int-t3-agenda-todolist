using System;
using System.Collections.Generic;
using agenda_api.Entities;
using agenda_api.Interfaces.Repository;
using agenda_api.Interfaces.Services;

namespace agenda_api.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _repository;
        private readonly ITaskRepository _taskRepository;

        public BoardService(IBoardRepository repository, ITaskRepository taskRepository)
        {
            _repository = repository;
            _taskRepository = taskRepository;
        }

        public int DeleteBoard(int id)
        {
            try
            {
                _repository.DeleteBoard(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }

        public List<Board> GetAll()
        {
            List<Board> boardList;
            try
            {
                boardList = _repository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            return boardList;
        }

        public List<Task> GetAllTasks(int boardId)
        {
            List<Task> taskListk;
            try
            {
                taskListk = _taskRepository.GetAllTasksByBoard(boardId);
            }
            catch (Exception e)
            {
                throw e;
            }

            return taskListk;
        }

        public Board GetById(int id)
        {
            Board board;
            try
            {
                board = _repository.GetById(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return board;
        }

        public Board SaveBoard(Board board)
        {
            try
            {
                _repository.SaveBoard(board);
            }
            catch (Exception e)
            {
                throw e;
            }

            return board;
        }

        public UpdateBoardRequest UpdateBoard(int id, UpdateBoardRequest board)
        {
            try
            {
                _repository.UpdateBoard(id, board);
            }
            catch (Exception e)
            {
                throw e;
            }

            return board;
        }
    }
}
