using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Wallago;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Wallago.unclassified_Wallago;

/// <summary>
/// Abstract class for unclassified Wallago (no rank).
/// NCBI TaxId: 2643508
/// </summary>
public abstract class unclassified_Wallago : Wallago, Iunclassified_Wallago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Wallago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643508;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Wallago";
}
