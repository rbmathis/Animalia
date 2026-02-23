namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Lepidochelys;

/// <summary>
/// Interface defining characteristics of Lepidochelys (genus).
/// </summary>
public interface ILepidochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
