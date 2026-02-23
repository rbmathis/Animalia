namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

/// <summary>
/// Interface defining characteristics of Berylmys (genus).
/// </summary>
public interface IBerylmys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
