namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Malacomys;

/// <summary>
/// Interface defining characteristics of Malacomys (genus).
/// </summary>
public interface IMalacomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
