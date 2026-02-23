namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Linophryne;

/// <summary>
/// Interface defining characteristics of Linophryne (genus).
/// </summary>
public interface ILinophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
