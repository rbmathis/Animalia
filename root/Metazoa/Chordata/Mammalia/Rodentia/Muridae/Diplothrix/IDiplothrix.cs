namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Diplothrix;

/// <summary>
/// Interface defining characteristics of Diplothrix (genus).
/// </summary>
public interface IDiplothrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
