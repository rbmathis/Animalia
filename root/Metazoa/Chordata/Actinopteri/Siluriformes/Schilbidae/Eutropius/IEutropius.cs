namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Eutropius;

/// <summary>
/// Interface defining characteristics of Eutropius (genus).
/// </summary>
public interface IEutropius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
