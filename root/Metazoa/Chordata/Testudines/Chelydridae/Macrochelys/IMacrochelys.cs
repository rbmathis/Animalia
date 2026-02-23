namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Macrochelys;

/// <summary>
/// Interface defining characteristics of Macrochelys (genus).
/// </summary>
public interface IMacrochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
