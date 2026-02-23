using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Atelerix;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Atelerix.unclassified_Atelerix;

/// <summary>
/// Abstract class for unclassified Atelerix (no rank).
/// NCBI TaxId: 2618624
/// </summary>
public abstract class unclassified_Atelerix : Atelerix, Iunclassified_Atelerix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atelerix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618624;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atelerix";
}
