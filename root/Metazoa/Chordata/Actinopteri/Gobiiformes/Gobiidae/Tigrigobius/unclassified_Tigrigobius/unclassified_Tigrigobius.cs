using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tigrigobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tigrigobius.unclassified_Tigrigobius;

/// <summary>
/// Abstract class for unclassified Tigrigobius (no rank).
/// NCBI TaxId: 2635265
/// </summary>
public abstract class unclassified_Tigrigobius : Tigrigobius, Iunclassified_Tigrigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tigrigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635265;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tigrigobius";
}
