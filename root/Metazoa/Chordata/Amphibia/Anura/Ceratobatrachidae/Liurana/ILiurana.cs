namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Liurana;

/// <summary>
/// Interface defining characteristics of Liurana (genus).
/// </summary>
public interface ILiurana
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
