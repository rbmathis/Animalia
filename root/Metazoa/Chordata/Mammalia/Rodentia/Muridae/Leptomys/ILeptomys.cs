namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leptomys;

/// <summary>
/// Interface defining characteristics of Leptomys (genus).
/// </summary>
public interface ILeptomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
