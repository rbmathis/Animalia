using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Priocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Priocharax.unclassified_Priocharax;

/// <summary>
/// Abstract class for unclassified Priocharax (no rank).
/// NCBI TaxId: 2752789
/// </summary>
public abstract class unclassified_Priocharax : Priocharax, Iunclassified_Priocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Priocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2752789;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Priocharax";
}
