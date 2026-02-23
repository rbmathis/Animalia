namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prunellidae.Prunella;

/// <summary>
/// Interface defining characteristics of Prunella (genus).
/// </summary>
public interface IPrunella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
