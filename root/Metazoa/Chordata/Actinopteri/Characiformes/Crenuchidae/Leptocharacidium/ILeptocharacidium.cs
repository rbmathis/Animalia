namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Leptocharacidium;

/// <summary>
/// Interface defining characteristics of Leptocharacidium (genus).
/// </summary>
public interface ILeptocharacidium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
