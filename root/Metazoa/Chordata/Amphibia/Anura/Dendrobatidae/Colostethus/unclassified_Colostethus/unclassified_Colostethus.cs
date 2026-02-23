using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Colostethus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Colostethus.unclassified_Colostethus;

/// <summary>
/// Abstract class for unclassified Colostethus (no rank).
/// NCBI TaxId: 2631876
/// </summary>
public abstract class unclassified_Colostethus : Colostethus, Iunclassified_Colostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Colostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631876;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Colostethus";
}
