namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Austroglanididae.Austroglanis;

/// <summary>
/// Interface defining characteristics of Austroglanis (genus).
/// </summary>
public interface IAustroglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
