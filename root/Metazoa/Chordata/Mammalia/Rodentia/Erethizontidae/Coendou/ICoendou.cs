namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou;

/// <summary>
/// Interface defining characteristics of Coendou (genus).
/// </summary>
public interface ICoendou
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
