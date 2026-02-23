namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pyrrhomyias;

/// <summary>
/// Interface defining characteristics of Pyrrhomyias (genus).
/// </summary>
public interface IPyrrhomyias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
