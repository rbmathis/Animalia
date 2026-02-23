namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Chironemidae.Chironemus;

/// <summary>
/// Interface defining characteristics of Chironemus (genus).
/// </summary>
public interface IChironemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
