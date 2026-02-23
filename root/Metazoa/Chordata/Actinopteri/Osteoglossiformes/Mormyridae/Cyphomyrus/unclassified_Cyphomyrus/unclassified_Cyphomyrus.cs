using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Cyphomyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Cyphomyrus.unclassified_Cyphomyrus;

/// <summary>
/// Abstract class for unclassified Cyphomyrus (no rank).
/// NCBI TaxId: 2809759
/// </summary>
public abstract class unclassified_Cyphomyrus : Cyphomyrus, Iunclassified_Cyphomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyphomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2809759;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyphomyrus";
}
