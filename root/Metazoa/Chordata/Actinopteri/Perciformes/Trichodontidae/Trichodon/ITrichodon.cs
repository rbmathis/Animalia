namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trichodontidae.Trichodon;

/// <summary>
/// Interface defining characteristics of Trichodon (genus).
/// </summary>
public interface ITrichodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
