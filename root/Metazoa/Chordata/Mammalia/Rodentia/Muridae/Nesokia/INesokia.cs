namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Nesokia;

/// <summary>
/// Interface defining characteristics of Nesokia (genus).
/// </summary>
public interface INesokia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
