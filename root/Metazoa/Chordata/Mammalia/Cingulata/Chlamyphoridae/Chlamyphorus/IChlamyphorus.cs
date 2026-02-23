namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Chlamyphorus;

/// <summary>
/// Interface defining characteristics of Chlamyphorus (genus).
/// </summary>
public interface IChlamyphorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
