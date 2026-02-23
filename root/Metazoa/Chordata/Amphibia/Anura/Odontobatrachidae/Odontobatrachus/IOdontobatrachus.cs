namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Odontobatrachidae.Odontobatrachus;

/// <summary>
/// Interface defining characteristics of Odontobatrachus (genus).
/// </summary>
public interface IOdontobatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
