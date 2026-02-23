namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Diplophidae.Diplophos;

/// <summary>
/// Interface defining characteristics of Diplophos (genus).
/// </summary>
public interface IDiplophos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
