--- Statemachine definition
--  For testing the statemachine callbacks

local client_sm = require('lua-state-machine/statemachine')﻿

function sm_config ()
  {
    local fsm = machine.create({
      intial = 'green',
      events = {
        { name = 'warn', from = 'green', to = 'yellow'},
        { name = 'panic', from = 'yellow', to = 'red'},
        { name = 'calm', from = 'red', to = 'yellow'},
        { name = 'clear', from = 'yellow', to = 'green'},
      }
    })

    return fsm
}

return client_sm;
