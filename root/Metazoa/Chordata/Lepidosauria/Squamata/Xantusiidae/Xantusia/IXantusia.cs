namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae.Xantusia;

/// <summary>
/// Interface defining characteristics of Xantusia (genus).
/// </summary>
public interface IXantusia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
