using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodontomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodontomys.unclassified_Sigmodontomys;

/// <summary>
/// Abstract class for unclassified Sigmodontomys (no rank).
/// NCBI TaxId: 2639592
/// </summary>
public abstract class unclassified_Sigmodontomys : Sigmodontomys, Iunclassified_Sigmodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sigmodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639592;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sigmodontomys";
}
