using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Hypomasticus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Hypomasticus.unclassified_Hypomasticus;

/// <summary>
/// Abstract class for unclassified Hypomasticus (no rank).
/// NCBI TaxId: 2732673
/// </summary>
public abstract class unclassified_Hypomasticus : Hypomasticus, Iunclassified_Hypomasticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypomasticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2732673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypomasticus";
}
