using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Pollimyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Pollimyrus.unclassified_Pollimyrus;

/// <summary>
/// Abstract class for unclassified Pollimyrus (no rank).
/// NCBI TaxId: 2637273
/// </summary>
public abstract class unclassified_Pollimyrus : Pollimyrus, Iunclassified_Pollimyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pollimyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637273;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pollimyrus";
}
