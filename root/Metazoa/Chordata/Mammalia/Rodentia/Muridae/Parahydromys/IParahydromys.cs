namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parahydromys;

/// <summary>
/// Interface defining characteristics of Parahydromys (genus).
/// </summary>
public interface IParahydromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
