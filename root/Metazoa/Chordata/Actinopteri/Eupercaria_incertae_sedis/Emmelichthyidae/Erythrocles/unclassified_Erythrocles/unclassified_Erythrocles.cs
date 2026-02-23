using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Erythrocles;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Erythrocles.unclassified_Erythrocles;

/// <summary>
/// Abstract class for unclassified Erythrocles (no rank).
/// NCBI TaxId: 2632752
/// </summary>
public abstract class unclassified_Erythrocles : Erythrocles, Iunclassified_Erythrocles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erythrocles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632752;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erythrocles";
}
