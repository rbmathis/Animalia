using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Phoeniculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Phoeniculidae.Phoeniculus;

/// <summary>
/// Abstract class for Phoeniculus (genus).
/// NCBI TaxId: 113099
/// </summary>
public abstract class Phoeniculus : Phoeniculidae, IPhoeniculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoeniculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 113099;

    /// <inheritdoc />
    public virtual string GenusName => "Phoeniculus";

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
