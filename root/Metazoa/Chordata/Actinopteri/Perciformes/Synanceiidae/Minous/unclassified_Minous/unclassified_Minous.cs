using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Minous;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Minous.unclassified_Minous;

/// <summary>
/// Abstract class for unclassified Minous (no rank).
/// NCBI TaxId: 2626522
/// </summary>
public abstract class unclassified_Minous : Minous, Iunclassified_Minous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Minous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626522;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Minous";
}
