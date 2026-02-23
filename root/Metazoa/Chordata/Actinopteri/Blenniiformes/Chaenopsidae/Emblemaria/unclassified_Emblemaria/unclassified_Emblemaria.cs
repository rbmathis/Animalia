using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Emblemaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Emblemaria.unclassified_Emblemaria;

/// <summary>
/// Abstract class for unclassified Emblemaria (no rank).
/// NCBI TaxId: 2644945
/// </summary>
public abstract class unclassified_Emblemaria : Emblemaria, Iunclassified_Emblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Emblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644945;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Emblemaria";
}
