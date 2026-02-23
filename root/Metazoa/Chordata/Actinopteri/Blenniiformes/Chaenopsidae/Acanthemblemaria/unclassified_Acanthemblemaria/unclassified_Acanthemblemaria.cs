using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Acanthemblemaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Acanthemblemaria.unclassified_Acanthemblemaria;

/// <summary>
/// Abstract class for unclassified Acanthemblemaria (no rank).
/// NCBI TaxId: 2633134
/// </summary>
public abstract class unclassified_Acanthemblemaria : Acanthemblemaria, Iunclassified_Acanthemblemaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthemblemaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633134;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthemblemaria";
}
