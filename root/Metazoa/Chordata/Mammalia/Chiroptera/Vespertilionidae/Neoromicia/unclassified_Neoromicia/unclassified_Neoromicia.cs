using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Neoromicia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Neoromicia.unclassified_Neoromicia;

/// <summary>
/// Abstract class for unclassified Neoromicia (no rank).
/// NCBI TaxId: 2636793
/// </summary>
public abstract class unclassified_Neoromicia : Neoromicia, Iunclassified_Neoromicia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoromicia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636793;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoromicia";
}
