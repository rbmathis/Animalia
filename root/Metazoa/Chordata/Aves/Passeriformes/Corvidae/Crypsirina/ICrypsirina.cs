namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Crypsirina;

/// <summary>
/// Interface defining characteristics of Crypsirina (genus).
/// </summary>
public interface ICrypsirina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
