namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Eretmochelys;

/// <summary>
/// Interface defining characteristics of Eretmochelys (genus).
/// </summary>
public interface IEretmochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
