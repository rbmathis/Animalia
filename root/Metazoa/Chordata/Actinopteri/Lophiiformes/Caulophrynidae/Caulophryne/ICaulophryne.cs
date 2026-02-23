namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Caulophrynidae.Caulophryne;

/// <summary>
/// Interface defining characteristics of Caulophryne (genus).
/// </summary>
public interface ICaulophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
