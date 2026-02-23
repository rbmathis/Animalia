namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Odontocharacidium;

/// <summary>
/// Interface defining characteristics of Odontocharacidium (genus).
/// </summary>
public interface IOdontocharacidium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
