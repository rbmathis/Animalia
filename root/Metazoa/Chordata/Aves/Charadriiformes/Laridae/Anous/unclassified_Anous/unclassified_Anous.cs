using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Anous;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Anous.unclassified_Anous;

/// <summary>
/// Abstract class for unclassified Anous (no rank).
/// NCBI TaxId: 2647379
/// </summary>
public abstract class unclassified_Anous : Anous, Iunclassified_Anous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647379;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anous";
}
