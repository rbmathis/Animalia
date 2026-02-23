namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Pronotogrammus;

/// <summary>
/// Interface defining characteristics of Pronotogrammus (genus).
/// </summary>
public interface IPronotogrammus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
