namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiruromys;

/// <summary>
/// Interface defining characteristics of Chiruromys (genus).
/// </summary>
public interface IChiruromys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
