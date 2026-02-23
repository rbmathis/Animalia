using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bandicota;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bandicota.unclassified_Bandicota;

/// <summary>
/// Abstract class for unclassified Bandicota (no rank).
/// NCBI TaxId: 2622524
/// </summary>
public abstract class unclassified_Bandicota : Bandicota, Iunclassified_Bandicota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bandicota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622524;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bandicota";
}
