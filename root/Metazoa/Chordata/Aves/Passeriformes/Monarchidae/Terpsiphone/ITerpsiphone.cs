namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Terpsiphone;

/// <summary>
/// Interface defining characteristics of Terpsiphone (genus).
/// </summary>
public interface ITerpsiphone
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
