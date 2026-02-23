namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Pseudalectrias;

/// <summary>
/// Interface defining characteristics of Pseudalectrias (genus).
/// </summary>
public interface IPseudalectrias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
