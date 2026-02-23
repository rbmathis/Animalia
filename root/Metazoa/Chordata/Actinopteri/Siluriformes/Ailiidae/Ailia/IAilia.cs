namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Ailia;

/// <summary>
/// Interface defining characteristics of Ailia (genus).
/// </summary>
public interface IAilia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
