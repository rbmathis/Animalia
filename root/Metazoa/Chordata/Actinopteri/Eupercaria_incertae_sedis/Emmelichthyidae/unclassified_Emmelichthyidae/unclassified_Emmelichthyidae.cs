using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.unclassified_Emmelichthyidae;

/// <summary>
/// Abstract class for unclassified Emmelichthyidae (no rank).
/// NCBI TaxId: 994742
/// </summary>
public abstract class unclassified_Emmelichthyidae : Emmelichthyidae, Iunclassified_Emmelichthyidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Emmelichthyidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 994742;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Emmelichthyidae";
}
