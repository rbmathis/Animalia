using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus.unclassified_Mammuthus;

/// <summary>
/// Abstract class for unclassified Mammuthus (no rank).
/// NCBI TaxId: 2627827
/// </summary>
public abstract class unclassified_Mammuthus : Mammuthus, Iunclassified_Mammuthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mammuthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627827;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mammuthus";
}
