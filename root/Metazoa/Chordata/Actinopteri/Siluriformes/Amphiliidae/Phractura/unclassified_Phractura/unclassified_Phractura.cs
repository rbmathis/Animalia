using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Phractura;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Phractura.unclassified_Phractura;

/// <summary>
/// Abstract class for unclassified Phractura (no rank).
/// NCBI TaxId: 2620141
/// </summary>
public abstract class unclassified_Phractura : Phractura, Iunclassified_Phractura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phractura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620141;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phractura";
}
