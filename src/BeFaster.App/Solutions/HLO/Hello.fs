namespace BeFaster.App.Solutions.HLO

open System

module Hello =
    let hello(friendName: string) = if friendName = "" then "Hello, World!" else "Hello, " + friendName + "!"
