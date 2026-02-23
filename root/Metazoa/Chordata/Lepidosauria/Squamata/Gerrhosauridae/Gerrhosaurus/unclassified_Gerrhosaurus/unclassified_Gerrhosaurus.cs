using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Gerrhosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Gerrhosaurus.unclassified_Gerrhosaurus;

/// <summary>
/// Abstract class for unclassified Gerrhosaurus (no rank).
/// NCBI TaxId: 2648450
/// </summary>
public abstract class unclassified_Gerrhosaurus : Gerrhosaurus, Iunclassified_Gerrhosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gerrhosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648450;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gerrhosaurus";
}
