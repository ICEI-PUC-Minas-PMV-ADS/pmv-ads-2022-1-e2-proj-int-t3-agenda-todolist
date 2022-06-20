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
        private readonly ITaskService _taskService;

        public BoardService(IBoardRepository repository, ITaskService taskService)
        {
            _repository = repository;
            _taskService = taskService;
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
            List<Board> response;
            try
            {
                response = _repository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }

        public List<TaskReponse> GetAllTasks(int boardId)
        {
            List<TaskReponse> reponse;
            try
            {
                reponse = _taskService.GetAllTasksByBoard(boardId);
            }
            catch (Exception e)
            {
                throw e;
            }

            return reponse;
        }

        public BoardResponse GetById(int id)
        {
            BoardResponse response;
            try
            {
                Board board = _repository.GetById(id);
                List<TaskReponse> boardTasks = _taskService.GetAllTasksByBoard(id);
                response = new BoardResponse(board, boardTasks);
            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
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
