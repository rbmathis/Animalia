namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Solomys;

/// <summary>
/// Interface defining characteristics of Solomys (genus).
/// </summary>
public interface ISolomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
