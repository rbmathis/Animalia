using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cynopotamus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cynopotamus.unclassified_Cynopotamus;

/// <summary>
/// Abstract class for unclassified Cynopotamus (no rank).
/// NCBI TaxId: 2621398
/// </summary>
public abstract class unclassified_Cynopotamus : Cynopotamus, Iunclassified_Cynopotamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynopotamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621398;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynopotamus";
}
