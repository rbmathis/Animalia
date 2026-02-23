using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.unclassified_Nemacheilidae;

/// <summary>
/// Abstract class for unclassified Nemacheilidae (no rank).
/// NCBI TaxId: 2925157
/// </summary>
public abstract class unclassified_Nemacheilidae : Nemacheilidae, Iunclassified_Nemacheilidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nemacheilidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2925157;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nemacheilidae";
}
