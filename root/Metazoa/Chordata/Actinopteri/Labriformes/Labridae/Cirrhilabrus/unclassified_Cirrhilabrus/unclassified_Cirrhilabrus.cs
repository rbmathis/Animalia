using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cirrhilabrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cirrhilabrus.unclassified_Cirrhilabrus;

/// <summary>
/// Abstract class for unclassified Cirrhilabrus (no rank).
/// NCBI TaxId: 2640053
/// </summary>
public abstract class unclassified_Cirrhilabrus : Cirrhilabrus, Iunclassified_Cirrhilabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirrhilabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640053;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirrhilabrus";
}
