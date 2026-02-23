namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Hapaloptila;

/// <summary>
/// Interface defining characteristics of Hapaloptila (genus).
/// </summary>
public interface IHapaloptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
