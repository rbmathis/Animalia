namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Stolephorus;

/// <summary>
/// Interface defining characteristics of Stolephorus (genus).
/// </summary>
public interface IStolephorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
