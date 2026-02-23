namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Actinemys;

/// <summary>
/// Interface defining characteristics of Actinemys (genus).
/// </summary>
public interface IActinemys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
