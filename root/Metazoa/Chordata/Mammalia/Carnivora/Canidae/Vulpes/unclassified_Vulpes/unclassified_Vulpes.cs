using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes.unclassified_Vulpes;

/// <summary>
/// Abstract class for unclassified Vulpes (no rank).
/// NCBI TaxId: 2627721
/// </summary>
public abstract class unclassified_Vulpes : Vulpes, Iunclassified_Vulpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vulpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627721;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vulpes";
}
