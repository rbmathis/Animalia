using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Yuriria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Yuriria.unclassified_Yuriria;

/// <summary>
/// Abstract class for unclassified Yuriria (no rank).
/// NCBI TaxId: 2623410
/// </summary>
public abstract class unclassified_Yuriria : Yuriria, Iunclassified_Yuriria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Yuriria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Yuriria";
}
