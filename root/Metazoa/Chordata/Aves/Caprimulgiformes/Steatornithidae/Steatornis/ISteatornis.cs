namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Steatornithidae.Steatornis;

/// <summary>
/// Interface defining characteristics of Steatornis (genus).
/// </summary>
public interface ISteatornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
