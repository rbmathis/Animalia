namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae.Echiichthys;

/// <summary>
/// Interface defining characteristics of Echiichthys (genus).
/// </summary>
public interface IEchiichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
