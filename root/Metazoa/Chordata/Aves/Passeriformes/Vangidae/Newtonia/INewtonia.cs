namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Newtonia;

/// <summary>
/// Interface defining characteristics of Newtonia (genus).
/// </summary>
public interface INewtonia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
