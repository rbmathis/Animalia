namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Noturus;

/// <summary>
/// Interface defining characteristics of Noturus (genus).
/// </summary>
public interface INoturus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
