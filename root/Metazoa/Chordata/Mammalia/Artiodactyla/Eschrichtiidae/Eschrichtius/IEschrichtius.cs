namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Eschrichtiidae.Eschrichtius;

/// <summary>
/// Interface defining characteristics of Eschrichtius (genus).
/// </summary>
public interface IEschrichtius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
