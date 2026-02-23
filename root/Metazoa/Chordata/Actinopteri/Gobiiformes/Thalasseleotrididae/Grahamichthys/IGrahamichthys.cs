namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae.Grahamichthys;

/// <summary>
/// Interface defining characteristics of Grahamichthys (genus).
/// </summary>
public interface IGrahamichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
