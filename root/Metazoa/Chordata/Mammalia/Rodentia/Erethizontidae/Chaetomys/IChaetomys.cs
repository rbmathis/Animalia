namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Chaetomys;

/// <summary>
/// Interface defining characteristics of Chaetomys (genus).
/// </summary>
public interface IChaetomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
