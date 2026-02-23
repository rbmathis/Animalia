namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Perccottus;

/// <summary>
/// Interface defining characteristics of Perccottus (genus).
/// </summary>
public interface IPerccottus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
