namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae.Triportheus;

/// <summary>
/// Interface defining characteristics of Triportheus (genus).
/// </summary>
public interface ITriportheus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
