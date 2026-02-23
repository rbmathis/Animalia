namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psilopsiagon;

/// <summary>
/// Interface defining characteristics of Psilopsiagon (genus).
/// </summary>
public interface IPsilopsiagon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
