namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Microligea;

/// <summary>
/// Interface defining characteristics of Microligea (genus).
/// </summary>
public interface IMicroligea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
