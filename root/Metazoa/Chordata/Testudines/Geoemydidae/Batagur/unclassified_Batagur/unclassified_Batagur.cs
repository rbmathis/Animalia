using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Batagur;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Batagur.unclassified_Batagur;

/// <summary>
/// Abstract class for unclassified Batagur (no rank).
/// NCBI TaxId: 623720
/// </summary>
public abstract class unclassified_Batagur : Batagur, Iunclassified_Batagur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batagur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 623720;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batagur";
}
