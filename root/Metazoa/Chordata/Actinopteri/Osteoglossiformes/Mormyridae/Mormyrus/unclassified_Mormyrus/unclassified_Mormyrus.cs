using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Mormyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Mormyrus.unclassified_Mormyrus;

/// <summary>
/// Abstract class for unclassified Mormyrus (no rank).
/// NCBI TaxId: 2640007
/// </summary>
public abstract class unclassified_Mormyrus : Mormyrus, Iunclassified_Mormyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mormyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640007;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mormyrus";
}
