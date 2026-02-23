namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Xyliphius;

/// <summary>
/// Interface defining characteristics of Xyliphius (genus).
/// </summary>
public interface IXyliphius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
