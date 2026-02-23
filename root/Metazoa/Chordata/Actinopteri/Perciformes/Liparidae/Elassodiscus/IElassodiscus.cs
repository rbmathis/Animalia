namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Elassodiscus;

/// <summary>
/// Interface defining characteristics of Elassodiscus (genus).
/// </summary>
public interface IElassodiscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
