using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.unclassified_Triglidae;

/// <summary>
/// Abstract class for unclassified Triglidae (no rank).
/// NCBI TaxId: 3472366
/// </summary>
public abstract class unclassified_Triglidae : Triglidae, Iunclassified_Triglidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triglidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3472366;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triglidae";
}
