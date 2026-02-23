using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Eurolophosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Eurolophosaurus.unclassified_Eurolophosaurus;

/// <summary>
/// Abstract class for unclassified Eurolophosaurus (no rank).
/// NCBI TaxId: 2631536
/// </summary>
public abstract class unclassified_Eurolophosaurus : Eurolophosaurus, Iunclassified_Eurolophosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eurolophosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631536;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eurolophosaurus";
}
