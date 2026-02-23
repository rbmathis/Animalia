namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lophuromys;

/// <summary>
/// Interface defining characteristics of Lophuromys (genus).
/// </summary>
public interface ILophuromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
