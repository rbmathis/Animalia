using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Onuxodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Onuxodon.unclassified_Onuxodon;

/// <summary>
/// Abstract class for unclassified Onuxodon (no rank).
/// NCBI TaxId: 2835838
/// </summary>
public abstract class unclassified_Onuxodon : Onuxodon, Iunclassified_Onuxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Onuxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835838;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Onuxodon";
}
