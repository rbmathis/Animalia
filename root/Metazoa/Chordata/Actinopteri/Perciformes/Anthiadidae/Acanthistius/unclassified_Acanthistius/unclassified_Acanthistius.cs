using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Acanthistius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Acanthistius.unclassified_Acanthistius;

/// <summary>
/// Abstract class for unclassified Acanthistius (no rank).
/// NCBI TaxId: 2625034
/// </summary>
public abstract class unclassified_Acanthistius : Acanthistius, Iunclassified_Acanthistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625034;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthistius";
}
