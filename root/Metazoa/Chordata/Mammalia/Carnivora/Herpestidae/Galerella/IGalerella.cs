namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Galerella;

/// <summary>
/// Interface defining characteristics of Galerella (genus).
/// </summary>
public interface IGalerella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
