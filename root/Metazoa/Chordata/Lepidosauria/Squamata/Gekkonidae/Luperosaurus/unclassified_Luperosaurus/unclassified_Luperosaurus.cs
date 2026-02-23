using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Luperosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Luperosaurus.unclassified_Luperosaurus;

/// <summary>
/// Abstract class for unclassified Luperosaurus (no rank).
/// NCBI TaxId: 2636195
/// </summary>
public abstract class unclassified_Luperosaurus : Luperosaurus, Iunclassified_Luperosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luperosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636195;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luperosaurus";
}
