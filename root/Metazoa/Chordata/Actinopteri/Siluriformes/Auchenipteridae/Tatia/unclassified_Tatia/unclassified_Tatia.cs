using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Tatia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Tatia.unclassified_Tatia;

/// <summary>
/// Abstract class for unclassified Tatia (no rank).
/// NCBI TaxId: 2635290
/// </summary>
public abstract class unclassified_Tatia : Tatia, Iunclassified_Tatia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tatia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635290;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tatia";
}
