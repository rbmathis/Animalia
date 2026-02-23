using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Erinaceus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Erinaceus.unclassified_Erinaceus;

/// <summary>
/// Abstract class for unclassified Erinaceus (no rank).
/// NCBI TaxId: 2618238
/// </summary>
public abstract class unclassified_Erinaceus : Erinaceus, Iunclassified_Erinaceus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erinaceus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618238;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erinaceus";
}
