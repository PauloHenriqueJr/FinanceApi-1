﻿namespace ApiStone.Data.Dtos.Balance
{
    public class CreateBalanceDto
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public double Value { get; set; }
    }
}
