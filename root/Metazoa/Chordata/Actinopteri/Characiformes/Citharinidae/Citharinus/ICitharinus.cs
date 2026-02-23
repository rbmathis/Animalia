namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Citharinus;

/// <summary>
/// Interface defining characteristics of Citharinus (genus).
/// </summary>
public interface ICitharinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
