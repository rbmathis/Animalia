using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Podogymnura;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Podogymnura.unclassified_Podogymnura;

/// <summary>
/// Abstract class for unclassified Podogymnura (no rank).
/// NCBI TaxId: 2995530
/// </summary>
public abstract class unclassified_Podogymnura : Podogymnura, Iunclassified_Podogymnura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Podogymnura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2995530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Podogymnura";
}
