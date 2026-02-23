namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Cholornis;

/// <summary>
/// Interface defining characteristics of Cholornis (genus).
/// </summary>
public interface ICholornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
