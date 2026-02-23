namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Pholidae.Apodichthys;

/// <summary>
/// Interface defining characteristics of Apodichthys (genus).
/// </summary>
public interface IApodichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
