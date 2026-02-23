namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Burramyidae.Cercartetus;

/// <summary>
/// Interface defining characteristics of Cercartetus (genus).
/// </summary>
public interface ICercartetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
