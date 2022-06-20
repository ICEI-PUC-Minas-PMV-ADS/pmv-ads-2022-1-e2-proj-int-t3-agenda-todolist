using System;
using System.Collections.Generic;
using agenda_api.Entities;

namespace agenda_api.Interfaces.Repository
{
    public interface IBoardRepository
    {
        public List<Board> GetAll();
        public Board GetById(int id);
        public Board SaveBoard(Board board);
        public UpdateBoardRequest UpdateBoard(int id, UpdateBoardRequest task);
        public int DeleteBoard(int id);
        
    }
}
