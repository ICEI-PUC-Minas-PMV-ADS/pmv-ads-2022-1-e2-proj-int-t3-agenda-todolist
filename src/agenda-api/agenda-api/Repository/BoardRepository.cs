using System;
using System.Collections.Generic;
using agenda_api.Entities;
using agenda_api.Interfaces.Repository;

namespace agenda_api.Repository
{
    public class BoardRepository : BaseRepository<Board>, IBoardRepository
    {
        private string TABLENAME = "Board";
        private string PARAMETERS = "Name, Description";

        public BoardRepository()
        {
            base._tableName = TABLENAME;
        }

        public List<Board> GetAll()
        {
            return base.getData("*");
        }

        public Board GetById(int id)
        {
            string condition = $"WHERE id={id}";
            return base.getData("*", condition)[0];
        }

        public Board SaveBoard(Board board)
        {
            int boardId;
            string values = $" '{board.Name}', '{board.Description}'";
            try
            {
                boardId = base.insertData(PARAMETERS, values);
            }
            catch (Exception e)
            {
                throw e;
            }
            board.Id = boardId;
            return board;
        }

        public UpdateBoardRequest UpdateBoard(int id, UpdateBoardRequest board)
        {
            string values = $" Name= '{board.Name}', Description = '{board.Description}' ";
            try
            {
                base.updateData(id, values);
            }
            catch (Exception e)
            {
                throw e;
            }
            return board;
        }

        public int DeleteBoard(int id)
        {
            try
            {
                base.deleteData($"'{id}'");
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }
    }
}
