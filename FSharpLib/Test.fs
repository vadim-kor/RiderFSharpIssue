namespace FSharpLib

open CSharpLib

module Test =
    let DemonstrateIssue() =
        let entity = Entity(1)
        
        // in Rider 2023.3.3, it shows 'set_Id' as a member of 'Entity' type
        // but should show "Id" property, which even doesn't have a setter actually
        entity.set_Id(1)
        
        // VisualStudio and Rider 2022.3.3 show "Id" property as expected
        //entity.Id
        
    