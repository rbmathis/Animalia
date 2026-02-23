namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Anabas;

/// <summary>
/// Interface defining characteristics of Anabas (genus).
/// </summary>
public interface IAnabas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
