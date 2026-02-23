using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Arvicanthis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Arvicanthis.unclassified_Arvicanthis;

/// <summary>
/// Abstract class for unclassified Arvicanthis (no rank).
/// NCBI TaxId: 2636980
/// </summary>
public abstract class unclassified_Arvicanthis : Arvicanthis, Iunclassified_Arvicanthis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arvicanthis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636980;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arvicanthis";
}
