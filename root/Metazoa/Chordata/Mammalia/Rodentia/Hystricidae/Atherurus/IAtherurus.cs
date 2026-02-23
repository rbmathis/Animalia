namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Atherurus;

/// <summary>
/// Interface defining characteristics of Atherurus (genus).
/// </summary>
public interface IAtherurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
