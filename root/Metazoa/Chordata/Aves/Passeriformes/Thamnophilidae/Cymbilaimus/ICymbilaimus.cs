namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Cymbilaimus;

/// <summary>
/// Interface defining characteristics of Cymbilaimus (genus).
/// </summary>
public interface ICymbilaimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
