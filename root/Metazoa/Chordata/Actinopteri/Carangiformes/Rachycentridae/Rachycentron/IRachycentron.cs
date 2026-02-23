namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Rachycentridae.Rachycentron;

/// <summary>
/// Interface defining characteristics of Rachycentron (genus).
/// </summary>
public interface IRachycentron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
