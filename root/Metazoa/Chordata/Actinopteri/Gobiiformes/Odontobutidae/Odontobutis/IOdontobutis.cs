namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Odontobutis;

/// <summary>
/// Interface defining characteristics of Odontobutis (genus).
/// </summary>
public interface IOdontobutis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
