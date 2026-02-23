using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Ivindomyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Ivindomyrus.unclassified_Ivindomyrus;

/// <summary>
/// Abstract class for unclassified Ivindomyrus (no rank).
/// NCBI TaxId: 2629753
/// </summary>
public abstract class unclassified_Ivindomyrus : Ivindomyrus, Iunclassified_Ivindomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ivindomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629753;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ivindomyrus";
}
