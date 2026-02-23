namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Schoeniparus;

/// <summary>
/// Interface defining characteristics of Schoeniparus (genus).
/// </summary>
public interface ISchoeniparus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
