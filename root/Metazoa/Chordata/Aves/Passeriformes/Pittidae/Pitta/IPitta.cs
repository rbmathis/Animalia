namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Pitta;

/// <summary>
/// Interface defining characteristics of Pitta (genus).
/// </summary>
public interface IPitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
