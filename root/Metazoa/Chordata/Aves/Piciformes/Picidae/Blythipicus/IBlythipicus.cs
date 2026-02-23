namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Blythipicus;

/// <summary>
/// Interface defining characteristics of Blythipicus (genus).
/// </summary>
public interface IBlythipicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
