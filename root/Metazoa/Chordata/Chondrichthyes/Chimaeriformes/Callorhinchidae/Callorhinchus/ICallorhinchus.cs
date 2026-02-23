namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Callorhinchidae.Callorhinchus;

/// <summary>
/// Interface defining characteristics of Callorhinchus (genus).
/// </summary>
public interface ICallorhinchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
