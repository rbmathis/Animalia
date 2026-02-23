namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Plecoglossidae.Plecoglossus;

/// <summary>
/// Interface defining characteristics of Plecoglossus (genus).
/// </summary>
public interface IPlecoglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
