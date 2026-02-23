namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Platemys;

/// <summary>
/// Interface defining characteristics of Platemys (genus).
/// </summary>
public interface IPlatemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
