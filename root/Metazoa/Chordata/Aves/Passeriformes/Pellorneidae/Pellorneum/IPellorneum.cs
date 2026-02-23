namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Pellorneum;

/// <summary>
/// Interface defining characteristics of Pellorneum (genus).
/// </summary>
public interface IPellorneum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
