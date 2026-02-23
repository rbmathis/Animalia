using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phyllotis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phyllotis.unclassified_Phyllotis;

/// <summary>
/// Abstract class for unclassified Phyllotis (no rank).
/// NCBI TaxId: 2620785
/// </summary>
public abstract class unclassified_Phyllotis : Phyllotis, Iunclassified_Phyllotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620785;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllotis";
}
