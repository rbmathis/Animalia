namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Ctenoscopelus;

/// <summary>
/// Interface defining characteristics of Ctenoscopelus (genus).
/// </summary>
public interface ICtenoscopelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
