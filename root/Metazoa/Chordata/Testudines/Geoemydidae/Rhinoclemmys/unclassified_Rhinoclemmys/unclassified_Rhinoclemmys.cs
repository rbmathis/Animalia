using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Rhinoclemmys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Rhinoclemmys.unclassified_Rhinoclemmys;

/// <summary>
/// Abstract class for unclassified Rhinoclemmys (no rank).
/// NCBI TaxId: 2905643
/// </summary>
public abstract class unclassified_Rhinoclemmys : Rhinoclemmys, Iunclassified_Rhinoclemmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinoclemmys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905643;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinoclemmys";
}
