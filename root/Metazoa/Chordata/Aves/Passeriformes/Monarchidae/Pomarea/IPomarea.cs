namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Pomarea;

/// <summary>
/// Interface defining characteristics of Pomarea (genus).
/// </summary>
public interface IPomarea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
