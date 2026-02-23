namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Anthropoides;

/// <summary>
/// Interface defining characteristics of Anthropoides (genus).
/// </summary>
public interface IAnthropoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
