using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Myoglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Myoglanis.unclassified_Myoglanis;

/// <summary>
/// Abstract class for unclassified Myoglanis (no rank).
/// NCBI TaxId: 2636616
/// </summary>
public abstract class unclassified_Myoglanis : Myoglanis, Iunclassified_Myoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636616;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myoglanis";
}
