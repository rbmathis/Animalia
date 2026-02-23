using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petinomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petinomys.unclassified_Petinomys;

/// <summary>
/// Abstract class for unclassified Petinomys (no rank).
/// NCBI TaxId: 2995524
/// </summary>
public abstract class unclassified_Petinomys : Petinomys, Iunclassified_Petinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2995524;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petinomys";
}
