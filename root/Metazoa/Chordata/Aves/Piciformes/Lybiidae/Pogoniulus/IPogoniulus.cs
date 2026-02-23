namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Pogoniulus;

/// <summary>
/// Interface defining characteristics of Pogoniulus (genus).
/// </summary>
public interface IPogoniulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
