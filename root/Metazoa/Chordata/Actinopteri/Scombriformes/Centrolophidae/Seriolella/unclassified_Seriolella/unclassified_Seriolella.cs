using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Seriolella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Seriolella.unclassified_Seriolella;

/// <summary>
/// Abstract class for unclassified Seriolella (no rank).
/// NCBI TaxId: 2617805
/// </summary>
public abstract class unclassified_Seriolella : Seriolella, Iunclassified_Seriolella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Seriolella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617805;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Seriolella";
}
