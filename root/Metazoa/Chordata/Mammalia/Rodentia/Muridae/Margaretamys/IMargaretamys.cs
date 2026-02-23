namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Margaretamys;

/// <summary>
/// Interface defining characteristics of Margaretamys (genus).
/// </summary>
public interface IMargaretamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
