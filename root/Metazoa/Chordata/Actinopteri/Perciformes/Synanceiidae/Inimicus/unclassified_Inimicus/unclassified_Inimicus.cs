using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Inimicus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Inimicus.unclassified_Inimicus;

/// <summary>
/// Abstract class for unclassified Inimicus (no rank).
/// NCBI TaxId: 2621025
/// </summary>
public abstract class unclassified_Inimicus : Inimicus, Iunclassified_Inimicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Inimicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621025;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Inimicus";
}
