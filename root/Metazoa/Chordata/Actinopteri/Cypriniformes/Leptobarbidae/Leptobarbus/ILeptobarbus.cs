namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leptobarbidae.Leptobarbus;

/// <summary>
/// Interface defining characteristics of Leptobarbus (genus).
/// </summary>
public interface ILeptobarbus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
