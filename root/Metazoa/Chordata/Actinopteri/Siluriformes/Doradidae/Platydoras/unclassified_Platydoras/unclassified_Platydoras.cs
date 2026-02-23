using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Platydoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Platydoras.unclassified_Platydoras;

/// <summary>
/// Abstract class for unclassified Platydoras (no rank).
/// NCBI TaxId: 2646172
/// </summary>
public abstract class unclassified_Platydoras : Platydoras, Iunclassified_Platydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646172;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platydoras";
}
