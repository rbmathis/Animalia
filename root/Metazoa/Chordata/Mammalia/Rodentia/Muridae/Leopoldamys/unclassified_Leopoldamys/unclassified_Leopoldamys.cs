using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leopoldamys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leopoldamys.unclassified_Leopoldamys;

/// <summary>
/// Abstract class for unclassified Leopoldamys (no rank).
/// NCBI TaxId: 2621192
/// </summary>
public abstract class unclassified_Leopoldamys : Leopoldamys, Iunclassified_Leopoldamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leopoldamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621192;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leopoldamys";
}
