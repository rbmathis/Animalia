using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Trachycephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Trachycephalus.unclassified_Trachycephalus;

/// <summary>
/// Abstract class for unclassified Trachycephalus (no rank).
/// NCBI TaxId: 2623682
/// </summary>
public abstract class unclassified_Trachycephalus : Trachycephalus, Iunclassified_Trachycephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachycephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623682;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachycephalus";
}
