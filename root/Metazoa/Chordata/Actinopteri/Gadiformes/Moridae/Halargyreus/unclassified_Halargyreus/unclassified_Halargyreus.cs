using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Halargyreus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Halargyreus.unclassified_Halargyreus;

/// <summary>
/// Abstract class for unclassified Halargyreus (no rank).
/// NCBI TaxId: 2636060
/// </summary>
public abstract class unclassified_Halargyreus : Halargyreus, Iunclassified_Halargyreus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Halargyreus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636060;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Halargyreus";
}
