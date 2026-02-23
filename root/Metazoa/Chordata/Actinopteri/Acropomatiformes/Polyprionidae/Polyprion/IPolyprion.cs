namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Polyprionidae.Polyprion;

/// <summary>
/// Interface defining characteristics of Polyprion (genus).
/// </summary>
public interface IPolyprion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
