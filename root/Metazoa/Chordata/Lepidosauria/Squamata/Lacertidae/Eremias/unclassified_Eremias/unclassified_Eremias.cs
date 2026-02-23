using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Eremias;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Eremias.unclassified_Eremias;

/// <summary>
/// Abstract class for unclassified Eremias (no rank).
/// NCBI TaxId: 2625460
/// </summary>
public abstract class unclassified_Eremias : Eremias, Iunclassified_Eremias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eremias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625460;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eremias";
}
