using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sueviota;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sueviota.unclassified_Sueviota;

/// <summary>
/// Abstract class for unclassified Sueviota (no rank).
/// NCBI TaxId: 2621248
/// </summary>
public abstract class unclassified_Sueviota : Sueviota, Iunclassified_Sueviota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sueviota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621248;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sueviota";
}
