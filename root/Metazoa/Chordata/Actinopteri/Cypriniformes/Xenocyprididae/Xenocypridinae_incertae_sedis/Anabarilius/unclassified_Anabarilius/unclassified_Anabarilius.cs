using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypridinae_incertae_sedis.Anabarilius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypridinae_incertae_sedis.Anabarilius.unclassified_Anabarilius;

/// <summary>
/// Abstract class for unclassified Anabarilius (no rank).
/// NCBI TaxId: 3447531
/// </summary>
public abstract class unclassified_Anabarilius : Anabarilius, Iunclassified_Anabarilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anabarilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3447531;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anabarilius";
}
