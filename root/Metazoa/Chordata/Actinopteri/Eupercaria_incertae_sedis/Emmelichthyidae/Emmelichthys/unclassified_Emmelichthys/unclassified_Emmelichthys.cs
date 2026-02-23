using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Emmelichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Emmelichthyidae.Emmelichthys.unclassified_Emmelichthys;

/// <summary>
/// Abstract class for unclassified Emmelichthys (no rank).
/// NCBI TaxId: 3108165
/// </summary>
public abstract class unclassified_Emmelichthys : Emmelichthys, Iunclassified_Emmelichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Emmelichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3108165;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Emmelichthys";
}
