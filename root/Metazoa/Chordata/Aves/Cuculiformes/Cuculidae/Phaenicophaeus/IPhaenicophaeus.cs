namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Phaenicophaeus;

/// <summary>
/// Interface defining characteristics of Phaenicophaeus (genus).
/// </summary>
public interface IPhaenicophaeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
