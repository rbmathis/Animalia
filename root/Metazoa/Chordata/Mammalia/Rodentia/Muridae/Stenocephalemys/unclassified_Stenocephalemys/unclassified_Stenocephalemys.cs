using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Stenocephalemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Stenocephalemys.unclassified_Stenocephalemys;

/// <summary>
/// Abstract class for unclassified Stenocephalemys (no rank).
/// NCBI TaxId: 2628246
/// </summary>
public abstract class unclassified_Stenocephalemys : Stenocephalemys, Iunclassified_Stenocephalemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stenocephalemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628246;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stenocephalemys";
}
