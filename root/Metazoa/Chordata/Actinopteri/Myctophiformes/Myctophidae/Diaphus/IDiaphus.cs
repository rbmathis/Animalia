namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Diaphus;

/// <summary>
/// Interface defining characteristics of Diaphus (genus).
/// </summary>
public interface IDiaphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
