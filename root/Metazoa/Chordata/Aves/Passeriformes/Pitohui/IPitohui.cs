namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pitohui;

/// <summary>
/// Interface defining characteristics of Pitohui (genus).
/// </summary>
public interface IPitohui
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
