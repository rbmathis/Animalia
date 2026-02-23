namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Laticilla;

/// <summary>
/// Interface defining characteristics of Laticilla (genus).
/// </summary>
public interface ILaticilla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
