using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Hippopotamyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Hippopotamyrus.unclassified_Hippopotamyrus;

/// <summary>
/// Abstract class for unclassified Hippopotamyrus (no rank).
/// NCBI TaxId: 2649583
/// </summary>
public abstract class unclassified_Hippopotamyrus : Hippopotamyrus, Iunclassified_Hippopotamyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hippopotamyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649583;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hippopotamyrus";
}
