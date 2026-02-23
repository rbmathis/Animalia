using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Scartella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Scartella.unclassified_Scartella;

/// <summary>
/// Abstract class for unclassified Scartella (no rank).
/// NCBI TaxId: 2624670
/// </summary>
public abstract class unclassified_Scartella : Scartella, Iunclassified_Scartella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scartella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624670;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scartella";
}
