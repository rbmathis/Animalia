namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Kasatkia;

/// <summary>
/// Interface defining characteristics of Kasatkia (genus).
/// </summary>
public interface IKasatkia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
