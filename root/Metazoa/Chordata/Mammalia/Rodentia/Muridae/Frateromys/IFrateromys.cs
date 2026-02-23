namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Frateromys;

/// <summary>
/// Interface defining characteristics of Frateromys (genus).
/// </summary>
public interface IFrateromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
