namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Conilurus;

/// <summary>
/// Interface defining characteristics of Conilurus (genus).
/// </summary>
public interface IConilurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
