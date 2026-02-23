namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Coccymys;

/// <summary>
/// Interface defining characteristics of Coccymys (genus).
/// </summary>
public interface ICoccymys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
