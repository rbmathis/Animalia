using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Prognathodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Chaetodontidae.Prognathodes.unclassified_Prognathodes;

/// <summary>
/// Abstract class for unclassified Prognathodes (no rank).
/// NCBI TaxId: 2627554
/// </summary>
public abstract class unclassified_Prognathodes : Prognathodes, Iunclassified_Prognathodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prognathodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627554;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prognathodes";
}
