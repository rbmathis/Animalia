using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Mesoclemmys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Mesoclemmys.unclassified_Mesoclemmys;

/// <summary>
/// Abstract class for unclassified Mesoclemmys (no rank).
/// NCBI TaxId: 2866222
/// </summary>
public abstract class unclassified_Mesoclemmys : Mesoclemmys, Iunclassified_Mesoclemmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mesoclemmys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2866222;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mesoclemmys";
}
