using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.unclassified_Doradidae;

/// <summary>
/// Abstract class for unclassified Doradidae (no rank).
/// NCBI TaxId: 1105760
/// </summary>
public abstract class unclassified_Doradidae : Doradidae, Iunclassified_Doradidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doradidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1105760;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doradidae";
}
