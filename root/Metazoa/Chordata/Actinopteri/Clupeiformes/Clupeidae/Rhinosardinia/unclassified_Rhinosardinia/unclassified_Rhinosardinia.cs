using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Rhinosardinia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Rhinosardinia.unclassified_Rhinosardinia;

/// <summary>
/// Abstract class for unclassified Rhinosardinia (no rank).
/// NCBI TaxId: 3410195
/// </summary>
public abstract class unclassified_Rhinosardinia : Rhinosardinia, Iunclassified_Rhinosardinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinosardinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3410195;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinosardinia";
}
