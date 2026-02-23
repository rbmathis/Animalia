namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Golunda;

/// <summary>
/// Interface defining characteristics of Golunda (genus).
/// </summary>
public interface IGolunda
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
