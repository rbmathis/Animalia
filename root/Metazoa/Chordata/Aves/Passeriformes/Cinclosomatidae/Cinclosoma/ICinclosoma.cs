namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Cinclosoma;

/// <summary>
/// Interface defining characteristics of Cinclosoma (genus).
/// </summary>
public interface ICinclosoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
