namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eulacestoma;

/// <summary>
/// Interface defining characteristics of Eulacestoma (genus).
/// </summary>
public interface IEulacestoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
