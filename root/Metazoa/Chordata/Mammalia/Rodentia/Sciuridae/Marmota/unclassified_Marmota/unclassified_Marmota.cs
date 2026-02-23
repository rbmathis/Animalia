using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota.unclassified_Marmota;

/// <summary>
/// Abstract class for unclassified Marmota (no rank).
/// NCBI TaxId: 2631887
/// </summary>
public abstract class unclassified_Marmota : Marmota, Iunclassified_Marmota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Marmota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631887;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Marmota";
}
