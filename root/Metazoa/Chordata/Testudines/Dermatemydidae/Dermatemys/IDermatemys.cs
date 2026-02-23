namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermatemydidae.Dermatemys;

/// <summary>
/// Interface defining characteristics of Dermatemys (genus).
/// </summary>
public interface IDermatemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
