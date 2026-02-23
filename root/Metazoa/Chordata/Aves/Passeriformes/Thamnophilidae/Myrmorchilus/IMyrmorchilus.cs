namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmorchilus;

/// <summary>
/// Interface defining characteristics of Myrmorchilus (genus).
/// </summary>
public interface IMyrmorchilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
