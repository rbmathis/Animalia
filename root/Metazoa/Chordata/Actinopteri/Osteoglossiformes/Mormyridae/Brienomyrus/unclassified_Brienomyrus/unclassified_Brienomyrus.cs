using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Brienomyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Brienomyrus.unclassified_Brienomyrus;

/// <summary>
/// Abstract class for unclassified Brienomyrus (no rank).
/// NCBI TaxId: 2684955
/// </summary>
public abstract class unclassified_Brienomyrus : Brienomyrus, Iunclassified_Brienomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brienomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684955;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brienomyrus";
}
