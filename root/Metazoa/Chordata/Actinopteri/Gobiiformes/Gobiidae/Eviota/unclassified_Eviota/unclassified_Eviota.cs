using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eviota;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eviota.unclassified_Eviota;

/// <summary>
/// Abstract class for unclassified Eviota (no rank).
/// NCBI TaxId: 2638558
/// </summary>
public abstract class unclassified_Eviota : Eviota, Iunclassified_Eviota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eviota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638558;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eviota";
}
