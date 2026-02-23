namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Colomys;

/// <summary>
/// Interface defining characteristics of Colomys (genus).
/// </summary>
public interface IColomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
