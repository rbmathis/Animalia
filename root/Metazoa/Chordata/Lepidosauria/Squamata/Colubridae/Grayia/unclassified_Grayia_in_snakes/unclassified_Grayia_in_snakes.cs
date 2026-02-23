using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Grayia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Grayia.unclassified_Grayia_in_snakes;

/// <summary>
/// Abstract class for unclassified Grayia (in: snakes) (no rank).
/// NCBI TaxId: 2856124
/// </summary>
public abstract class unclassified_Grayia_in_snakes : Grayia, Iunclassified_Grayia_in_snakes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Grayia (in: snakes)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2856124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Grayia_in_snakes";
}
