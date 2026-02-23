using AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae.Protopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae.Protopterus.unclassified_Protopterus;

/// <summary>
/// Abstract class for unclassified Protopterus (no rank).
/// NCBI TaxId: 2631722
/// </summary>
public abstract class unclassified_Protopterus : Protopterus, Iunclassified_Protopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Protopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631722;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Protopterus";
}
