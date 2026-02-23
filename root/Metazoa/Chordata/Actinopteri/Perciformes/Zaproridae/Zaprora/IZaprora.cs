namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zaproridae.Zaprora;

/// <summary>
/// Interface defining characteristics of Zaprora (genus).
/// </summary>
public interface IZaprora
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
