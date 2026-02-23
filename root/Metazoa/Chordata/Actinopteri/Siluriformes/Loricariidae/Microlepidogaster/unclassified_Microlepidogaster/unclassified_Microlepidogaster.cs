using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Microlepidogaster;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Microlepidogaster.unclassified_Microlepidogaster;

/// <summary>
/// Abstract class for unclassified Microlepidogaster (no rank).
/// NCBI TaxId: 2642978
/// </summary>
public abstract class unclassified_Microlepidogaster : Microlepidogaster, Iunclassified_Microlepidogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microlepidogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642978;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microlepidogaster";
}
