namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Pantosteus;

/// <summary>
/// Interface defining characteristics of Pantosteus (genus).
/// </summary>
public interface IPantosteus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
