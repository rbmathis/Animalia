using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sundamys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sundamys.unclassified_Sundamys;

/// <summary>
/// Abstract class for unclassified Sundamys (no rank).
/// NCBI TaxId: 3381571
/// </summary>
public abstract class unclassified_Sundamys : Sundamys, Iunclassified_Sundamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sundamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3381571;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sundamys";
}
