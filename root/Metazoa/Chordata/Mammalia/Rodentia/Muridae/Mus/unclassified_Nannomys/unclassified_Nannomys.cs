using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus.unclassified_Nannomys;

/// <summary>
/// Abstract class for unclassified Nannomys (no rank).
/// NCBI TaxId: 2723282
/// </summary>
public abstract class unclassified_Nannomys : Mus, Iunclassified_Nannomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2723282;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannomys";
}
