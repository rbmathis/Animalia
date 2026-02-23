using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Naultinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Naultinus.unclassified_Naultinus;

/// <summary>
/// Abstract class for unclassified Naultinus (no rank).
/// NCBI TaxId: 2640864
/// </summary>
public abstract class unclassified_Naultinus : Naultinus, Iunclassified_Naultinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Naultinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640864;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Naultinus";
}
