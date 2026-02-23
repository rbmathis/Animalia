using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Hemisorubim;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Hemisorubim.unclassified_Hemisorubim;

/// <summary>
/// Abstract class for unclassified Hemisorubim (no rank).
/// NCBI TaxId: 3101853
/// </summary>
public abstract class unclassified_Hemisorubim : Hemisorubim, Iunclassified_Hemisorubim
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemisorubim";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101853;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemisorubim";
}
