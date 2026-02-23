namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Leucocephalophus;

/// <summary>
/// Interface defining characteristics of Leucocephalophus (genus).
/// </summary>
public interface ILeucocephalophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
