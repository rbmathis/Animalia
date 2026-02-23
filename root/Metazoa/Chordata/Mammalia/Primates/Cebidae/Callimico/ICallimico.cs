namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callimico;

/// <summary>
/// Interface defining characteristics of Callimico (genus).
/// </summary>
public interface ICallimico
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
