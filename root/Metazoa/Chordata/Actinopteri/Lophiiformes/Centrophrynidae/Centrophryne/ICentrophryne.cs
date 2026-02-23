namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Centrophrynidae.Centrophryne;

/// <summary>
/// Interface defining characteristics of Centrophryne (genus).
/// </summary>
public interface ICentrophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
