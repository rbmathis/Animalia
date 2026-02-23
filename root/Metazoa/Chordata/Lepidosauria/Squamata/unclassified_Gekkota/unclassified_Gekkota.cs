using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Gekkota;

/// <summary>
/// Abstract class for unclassified Gekkota (no rank).
/// NCBI TaxId: 728168
/// </summary>
public abstract class unclassified_Gekkota : Squamata, Iunclassified_Gekkota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gekkota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 728168;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gekkota";
}
