using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae.Typhlomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Platacanthomyidae.Typhlomys.unclassified_Typhlomys;

/// <summary>
/// Abstract class for unclassified Typhlomys (no rank).
/// NCBI TaxId: 2720085
/// </summary>
public abstract class unclassified_Typhlomys : Typhlomys, Iunclassified_Typhlomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Typhlomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2720085;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Typhlomys";
}
