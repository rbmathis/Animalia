using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Prionotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Prionotus.unclassified_Prionotus;

/// <summary>
/// Abstract class for unclassified Prionotus (no rank).
/// NCBI TaxId: 2618196
/// </summary>
public abstract class unclassified_Prionotus : Prionotus, Iunclassified_Prionotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prionotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618196;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prionotus";
}
