namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lophotidae.Lophotus;

/// <summary>
/// Interface defining characteristics of Lophotus (genus).
/// </summary>
public interface ILophotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
