﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICardService
    {
        IDataResult<List<Card>> GetAll();
        IDataResult<Card> GetById(int cardId);
        IDataResult<Card> GetByCardNumber(int cardNumber);
        IResult DoesCardExist(Card card);
        IResult Add(Card card);
        IResult Update(Card card);
        IResult Delete(Card card);
    }
}
