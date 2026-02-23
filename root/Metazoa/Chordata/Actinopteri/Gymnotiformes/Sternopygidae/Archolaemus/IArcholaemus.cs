namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Archolaemus;

/// <summary>
/// Interface defining characteristics of Archolaemus (genus).
/// </summary>
public interface IArcholaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
