using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Megalonema;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Megalonema.unclassified_Megalonema;

/// <summary>
/// Abstract class for unclassified Megalonema (no rank).
/// NCBI TaxId: 2622885
/// </summary>
public abstract class unclassified_Megalonema : Megalonema, Iunclassified_Megalonema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megalonema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622885;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megalonema";
}
