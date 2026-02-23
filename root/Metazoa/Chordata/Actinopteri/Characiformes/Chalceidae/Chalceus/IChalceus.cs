namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chalceidae.Chalceus;

/// <summary>
/// Interface defining characteristics of Chalceus (genus).
/// </summary>
public interface IChalceus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
