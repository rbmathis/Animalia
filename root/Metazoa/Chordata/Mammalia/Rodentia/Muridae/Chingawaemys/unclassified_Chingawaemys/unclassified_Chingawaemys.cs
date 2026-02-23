using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chingawaemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chingawaemys.unclassified_Chingawaemys;

/// <summary>
/// Abstract class for unclassified Chingawaemys (no rank).
/// NCBI TaxId: 2954919
/// </summary>
public abstract class unclassified_Chingawaemys : Chingawaemys, Iunclassified_Chingawaemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chingawaemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2954919;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chingawaemys";
}
