// Learn more about F# at http://fsharp.org

open System


[<EntryPoint>]
let main argv =


    let a = DotSpatial.Projections.ProjectionInfo.FromEpsgCode 32756
    let b = DotSpatial.Projections.ProjectionInfo.FromEpsgCode 3857


    let xy = [|337865.2269059850368649;6250798.0734301581978798|]
    let z = [|0.0|]
    DotSpatial.Projections.Reproject.ReprojectPoints(xy, z, a, b, 0, 1)


    let should = [| 16836745.65; -4011453.12 |]

    printfn "%A" should
    printfn "%A" xy

    0 // return an integer exit code
