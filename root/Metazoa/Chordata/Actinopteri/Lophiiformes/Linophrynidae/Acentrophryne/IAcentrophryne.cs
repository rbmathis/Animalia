namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Acentrophryne;

/// <summary>
/// Interface defining characteristics of Acentrophryne (genus).
/// </summary>
public interface IAcentrophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
