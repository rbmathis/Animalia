using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys.unclassified_Oecomys;

/// <summary>
/// Abstract class for unclassified Oecomys (no rank).
/// NCBI TaxId: 2620455
/// </summary>
public abstract class unclassified_Oecomys : Oecomys, Iunclassified_Oecomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oecomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620455;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oecomys";
}
