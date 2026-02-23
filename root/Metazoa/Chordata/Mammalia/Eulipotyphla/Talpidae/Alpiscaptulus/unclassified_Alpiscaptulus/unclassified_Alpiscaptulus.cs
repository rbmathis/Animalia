using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Alpiscaptulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Alpiscaptulus.unclassified_Alpiscaptulus;

/// <summary>
/// Abstract class for unclassified Alpiscaptulus (no rank).
/// NCBI TaxId: 2917338
/// </summary>
public abstract class unclassified_Alpiscaptulus : Alpiscaptulus, Iunclassified_Alpiscaptulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alpiscaptulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2917338;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alpiscaptulus";
}
