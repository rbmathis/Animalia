using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Cassiculus;

/// <summary>
/// Abstract class for Cassiculus (genus).
/// NCBI TaxId: 3150798
/// </summary>
public abstract class Cassiculus : Icteridae, ICassiculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cassiculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150798;

    /// <inheritdoc />
    public virtual string GenusName => "Cassiculus";

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
