using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus.unclassified_Suncus;

/// <summary>
/// Abstract class for unclassified Suncus (no rank).
/// NCBI TaxId: 2638714
/// </summary>
public abstract class unclassified_Suncus : Suncus, Iunclassified_Suncus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Suncus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638714;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Suncus";
}
