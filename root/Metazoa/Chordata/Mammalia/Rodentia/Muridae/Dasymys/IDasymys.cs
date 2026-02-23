namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dasymys;

/// <summary>
/// Interface defining characteristics of Dasymys (genus).
/// </summary>
public interface IDasymys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
