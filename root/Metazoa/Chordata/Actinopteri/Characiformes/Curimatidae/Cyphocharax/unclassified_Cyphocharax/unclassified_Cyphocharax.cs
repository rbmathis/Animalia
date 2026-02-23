using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Cyphocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Cyphocharax.unclassified_Cyphocharax;

/// <summary>
/// Abstract class for unclassified Cyphocharax (no rank).
/// NCBI TaxId: 2642274
/// </summary>
public abstract class unclassified_Cyphocharax : Cyphocharax, Iunclassified_Cyphocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyphocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642274;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyphocharax";
}
