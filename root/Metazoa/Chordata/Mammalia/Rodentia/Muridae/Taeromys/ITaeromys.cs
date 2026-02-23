namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Taeromys;

/// <summary>
/// Interface defining characteristics of Taeromys (genus).
/// </summary>
public interface ITaeromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
