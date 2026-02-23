namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sekeetamys;

/// <summary>
/// Interface defining characteristics of Sekeetamys (genus).
/// </summary>
public interface ISekeetamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
