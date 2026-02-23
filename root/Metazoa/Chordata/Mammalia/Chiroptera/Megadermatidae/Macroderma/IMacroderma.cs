namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Macroderma;

/// <summary>
/// Interface defining characteristics of Macroderma (genus).
/// </summary>
public interface IMacroderma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
