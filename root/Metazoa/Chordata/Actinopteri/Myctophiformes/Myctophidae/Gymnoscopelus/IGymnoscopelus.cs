namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Gymnoscopelus;

/// <summary>
/// Interface defining characteristics of Gymnoscopelus (genus).
/// </summary>
public interface IGymnoscopelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
