namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dipodillus;

/// <summary>
/// Interface defining characteristics of Dipodillus (genus).
/// </summary>
public interface IDipodillus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
