using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thelotornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thelotornis.unclassified_Thelotornis;

/// <summary>
/// Abstract class for unclassified Thelotornis (no rank).
/// NCBI TaxId: 2633435
/// </summary>
public abstract class unclassified_Thelotornis : Thelotornis, Iunclassified_Thelotornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thelotornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633435;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thelotornis";
}
