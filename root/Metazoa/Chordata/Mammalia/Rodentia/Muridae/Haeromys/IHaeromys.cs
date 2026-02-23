namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Haeromys;

/// <summary>
/// Interface defining characteristics of Haeromys (genus).
/// </summary>
public interface IHaeromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
