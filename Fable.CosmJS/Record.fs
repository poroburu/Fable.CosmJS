module Fable.CosmJS.Record

open System.Collections.Generic
open Fable.Core.JS


type Record<'Key, 'T> = Map<'Key , 'T> 

