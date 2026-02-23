namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Psilorhinus;

/// <summary>
/// Interface defining characteristics of Psilorhinus (genus).
/// </summary>
public interface IPsilorhinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
