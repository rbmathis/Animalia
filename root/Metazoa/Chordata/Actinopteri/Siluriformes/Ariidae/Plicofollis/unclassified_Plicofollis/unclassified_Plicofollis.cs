using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Plicofollis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Plicofollis.unclassified_Plicofollis;

/// <summary>
/// Abstract class for unclassified Plicofollis (no rank).
/// NCBI TaxId: 2861738
/// </summary>
public abstract class unclassified_Plicofollis : Plicofollis, Iunclassified_Plicofollis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plicofollis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861738;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plicofollis";
}
