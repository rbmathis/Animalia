using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius.unclassified_Charadrius;

/// <summary>
/// Abstract class for unclassified Charadrius (no rank).
/// NCBI TaxId: 2699394
/// </summary>
public abstract class unclassified_Charadrius : Charadrius, Iunclassified_Charadrius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Charadrius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2699394;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Charadrius";
}
