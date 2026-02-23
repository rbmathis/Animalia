namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Thalasseleotrididae.Tempestichthys;

/// <summary>
/// Interface defining characteristics of Tempestichthys (genus).
/// </summary>
public interface ITempestichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
