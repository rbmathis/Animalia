namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Catagonus;

/// <summary>
/// Interface defining characteristics of Catagonus (genus).
/// </summary>
public interface ICatagonus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
