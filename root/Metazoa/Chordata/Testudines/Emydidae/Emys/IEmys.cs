namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emys;

/// <summary>
/// Interface defining characteristics of Emys (genus).
/// </summary>
public interface IEmys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
