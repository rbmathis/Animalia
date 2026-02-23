namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Notochelys;

/// <summary>
/// Interface defining characteristics of Notochelys (genus).
/// </summary>
public interface INotochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
