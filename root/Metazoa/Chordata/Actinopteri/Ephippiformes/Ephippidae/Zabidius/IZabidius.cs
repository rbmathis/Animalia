namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Zabidius;

/// <summary>
/// Interface defining characteristics of Zabidius (genus).
/// </summary>
public interface IZabidius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
