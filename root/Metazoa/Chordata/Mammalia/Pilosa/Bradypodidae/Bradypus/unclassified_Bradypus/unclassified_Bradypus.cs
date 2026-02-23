using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Bradypodidae.Bradypus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Bradypodidae.Bradypus.unclassified_Bradypus;

/// <summary>
/// Abstract class for unclassified Bradypus (no rank).
/// NCBI TaxId: 2624268
/// </summary>
public abstract class unclassified_Bradypus : Bradypus, Iunclassified_Bradypus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bradypus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624268;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bradypus";
}
