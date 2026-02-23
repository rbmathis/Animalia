namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Myuchelys;

/// <summary>
/// Interface defining characteristics of Myuchelys (genus).
/// </summary>
public interface IMyuchelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
