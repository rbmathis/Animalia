namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sundamys;

/// <summary>
/// Interface defining characteristics of Sundamys (genus).
/// </summary>
public interface ISundamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
