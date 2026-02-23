namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Tyrannophryne;

/// <summary>
/// Interface defining characteristics of Tyrannophryne (genus).
/// </summary>
public interface ITyrannophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
