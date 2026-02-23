using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Eurymen;

/// <summary>
/// Abstract class for Eurymen (genus).
/// NCBI TaxId: 980412
/// </summary>
public abstract class Eurymen : Psychrolutidae, IEurymen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurymen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 980412;

    /// <inheritdoc />
    public virtual string GenusName => "Eurymen";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
