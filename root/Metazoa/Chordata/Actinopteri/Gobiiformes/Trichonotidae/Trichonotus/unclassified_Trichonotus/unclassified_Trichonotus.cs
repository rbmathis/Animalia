using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Trichonotidae.Trichonotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Trichonotidae.Trichonotus.unclassified_Trichonotus;

/// <summary>
/// Abstract class for unclassified Trichonotus (no rank).
/// NCBI TaxId: 2619233
/// </summary>
public abstract class unclassified_Trichonotus : Trichonotus, Iunclassified_Trichonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trichonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619233;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trichonotus";
}
