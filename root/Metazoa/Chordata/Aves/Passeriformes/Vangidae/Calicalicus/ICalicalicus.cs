namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Calicalicus;

/// <summary>
/// Interface defining characteristics of Calicalicus (genus).
/// </summary>
public interface ICalicalicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
