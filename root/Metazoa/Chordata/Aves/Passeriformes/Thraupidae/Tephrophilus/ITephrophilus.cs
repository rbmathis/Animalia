namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Tephrophilus;

/// <summary>
/// Interface defining characteristics of Tephrophilus (genus).
/// </summary>
public interface ITephrophilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
