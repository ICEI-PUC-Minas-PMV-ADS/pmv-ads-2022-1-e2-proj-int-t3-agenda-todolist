using System;
using System.Collections.Generic;
using agenda_api.Entities;

namespace agenda_api.Interfaces.Services
{
    public interface IBoardService
    {
        public List<Board> GetAll();
        public BoardResponse GetById(int id);
        public Board SaveBoard(Board board);
        public List<TaskReponse> GetAllTasks(int boardId);
        public UpdateBoardRequest UpdateBoard(int id, UpdateBoardRequest task);
        public int DeleteBoard(int id);
    }
}
