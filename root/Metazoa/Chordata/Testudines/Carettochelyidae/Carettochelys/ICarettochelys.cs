namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Carettochelyidae.Carettochelys;

/// <summary>
/// Interface defining characteristics of Carettochelys (genus).
/// </summary>
public interface ICarettochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
