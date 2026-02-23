namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Leptoscopidae.Crapatalus;

/// <summary>
/// Interface defining characteristics of Crapatalus (genus).
/// </summary>
public interface ICrapatalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
