local smwrapper = {}
local fileName="smwrapper.lua"

local simulatorVariables={}

function stateChangeNotification(event, from, to)
	print("smwrapper: State change on " .. event .. " from " .. from .. " to " .. to)
end

function initialise()
	print("smwrapper: initialise()")

	print("smwrapper: initialise end")
end

function reportName()
	local name = fileName .. "smwrapper:reportName()"
	return name
end

print fileName .. " loaded"

return smwrapper