namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Astroscopus;

/// <summary>
/// Interface defining characteristics of Astroscopus (genus).
/// </summary>
public interface IAstroscopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
