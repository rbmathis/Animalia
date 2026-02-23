using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Campylomormyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Campylomormyrus.unclassified_Campylomormyrus;

/// <summary>
/// Abstract class for unclassified Campylomormyrus (no rank).
/// NCBI TaxId: 2638143
/// </summary>
public abstract class unclassified_Campylomormyrus : Campylomormyrus, Iunclassified_Campylomormyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Campylomormyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638143;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Campylomormyrus";
}
