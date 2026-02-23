namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Doedicurus;

/// <summary>
/// Interface defining characteristics of Doedicurus (genus).
/// </summary>
public interface IDoedicurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
