using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Glaucomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Glaucomys.unclassified_Glaucomys;

/// <summary>
/// Abstract class for unclassified Glaucomys (no rank).
/// NCBI TaxId: 2635303
/// </summary>
public abstract class unclassified_Glaucomys : Glaucomys, Iunclassified_Glaucomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glaucomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635303;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glaucomys";
}
