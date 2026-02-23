namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Melanonidae.Melanonus;

/// <summary>
/// Interface defining characteristics of Melanonus (genus).
/// </summary>
public interface IMelanonus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
