namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Nyctophilus;

/// <summary>
/// Interface defining characteristics of Nyctophilus (genus).
/// </summary>
public interface INyctophilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
