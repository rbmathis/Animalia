namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Habrophallos;

/// <summary>
/// Interface defining characteristics of Habrophallos (genus).
/// </summary>
public interface IHabrophallos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
