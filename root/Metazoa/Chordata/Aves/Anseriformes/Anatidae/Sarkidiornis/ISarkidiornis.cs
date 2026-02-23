namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Sarkidiornis;

/// <summary>
/// Interface defining characteristics of Sarkidiornis (genus).
/// </summary>
public interface ISarkidiornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
