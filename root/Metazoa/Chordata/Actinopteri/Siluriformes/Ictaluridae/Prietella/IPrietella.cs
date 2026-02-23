namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Prietella;

/// <summary>
/// Interface defining characteristics of Prietella (genus).
/// </summary>
public interface IPrietella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
