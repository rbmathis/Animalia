using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Heteromormyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Heteromormyrus.unclassified_Heteromormyrus;

/// <summary>
/// Abstract class for unclassified Heteromormyrus (no rank).
/// NCBI TaxId: 2929484
/// </summary>
public abstract class unclassified_Heteromormyrus : Heteromormyrus, Iunclassified_Heteromormyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heteromormyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2929484;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heteromormyrus";
}
