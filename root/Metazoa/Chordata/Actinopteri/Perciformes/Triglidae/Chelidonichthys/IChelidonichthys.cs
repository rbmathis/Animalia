namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Chelidonichthys;

/// <summary>
/// Interface defining characteristics of Chelidonichthys (genus).
/// </summary>
public interface IChelidonichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
