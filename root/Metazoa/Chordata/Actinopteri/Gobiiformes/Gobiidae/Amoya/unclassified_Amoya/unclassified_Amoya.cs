using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amoya;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amoya.unclassified_Amoya;

/// <summary>
/// Abstract class for unclassified Amoya (no rank).
/// NCBI TaxId: 2643282
/// </summary>
public abstract class unclassified_Amoya : Amoya, Iunclassified_Amoya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amoya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643282;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amoya";
}
