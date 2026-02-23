namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Lagenodelphis;

/// <summary>
/// Interface defining characteristics of Lagenodelphis (genus).
/// </summary>
public interface ILagenodelphis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
