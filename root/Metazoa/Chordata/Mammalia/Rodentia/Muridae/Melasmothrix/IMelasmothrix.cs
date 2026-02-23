namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Melasmothrix;

/// <summary>
/// Interface defining characteristics of Melasmothrix (genus).
/// </summary>
public interface IMelasmothrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
