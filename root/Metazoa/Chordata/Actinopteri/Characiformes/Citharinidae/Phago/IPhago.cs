namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Phago;

/// <summary>
/// Interface defining characteristics of Phago (genus).
/// </summary>
public interface IPhago
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
