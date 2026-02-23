namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottocomephorus;

/// <summary>
/// Interface defining characteristics of Cottocomephorus (genus).
/// </summary>
public interface ICottocomephorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
