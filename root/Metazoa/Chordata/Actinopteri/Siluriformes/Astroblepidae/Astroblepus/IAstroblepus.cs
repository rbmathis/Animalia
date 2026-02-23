namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Astroblepidae.Astroblepus;

/// <summary>
/// Interface defining characteristics of Astroblepus (genus).
/// </summary>
public interface IAstroblepus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
