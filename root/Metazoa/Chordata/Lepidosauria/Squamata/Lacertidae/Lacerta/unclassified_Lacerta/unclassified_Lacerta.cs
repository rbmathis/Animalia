using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Lacerta;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Lacerta.unclassified_Lacerta;

/// <summary>
/// Abstract class for unclassified Lacerta (no rank).
/// NCBI TaxId: 3231690
/// </summary>
public abstract class unclassified_Lacerta : Lacerta, Iunclassified_Lacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3231690;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lacerta";
}
