﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE2_Ins_If : BE2_InstructionBase, I_BE2_Instruction
{
    //protected override void OnAwake()
    //{
    //    
    //}

    //protected override void OnStart()
    //{
    //    
    //}

    I_BE2_BlockSectionHeaderInput _input0;
    string _value;
    bool _isFirstPlay = true;

    protected override void OnButtonStop()
    {
        _isFirstPlay = true;
    }

    public override void OnStackActive()
    {
        _isFirstPlay = true;
    }

    public new void Function()
    {

        //EndLoop = true;
        if (_isFirstPlay)
        {
            _input0 = Section0Inputs[0];
            _value = _input0.StringValue;
            Debug.Log(Section0Inputs[0]);
            Debug.Log(_value);



            if (_value == "1" || _value == "true")
            {
                _isFirstPlay = false;
                ExecuteSection(0);
            }
            else
            {
                _isFirstPlay = true;
                ExecuteNextInstruction();
            }
        }
        else
        {
            _isFirstPlay = true;
            ExecuteNextInstruction();
        }
    }
}
