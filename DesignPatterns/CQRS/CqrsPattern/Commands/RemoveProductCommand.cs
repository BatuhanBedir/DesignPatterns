﻿namespace CQRS.CqrsPattern.Commands
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int id)
        {
               Id = id; 
        }
        public int Id { get; set; }
    }
}
