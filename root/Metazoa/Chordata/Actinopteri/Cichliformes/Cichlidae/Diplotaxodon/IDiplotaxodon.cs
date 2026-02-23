namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Diplotaxodon;

/// <summary>
/// Interface defining characteristics of Diplotaxodon (genus).
/// </summary>
public interface IDiplotaxodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
