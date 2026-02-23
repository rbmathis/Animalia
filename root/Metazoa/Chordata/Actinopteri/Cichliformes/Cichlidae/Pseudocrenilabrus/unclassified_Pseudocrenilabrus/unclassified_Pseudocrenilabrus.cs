using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudocrenilabrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudocrenilabrus.unclassified_Pseudocrenilabrus;

/// <summary>
/// Abstract class for unclassified Pseudocrenilabrus (no rank).
/// NCBI TaxId: 2636583
/// </summary>
public abstract class unclassified_Pseudocrenilabrus : Pseudocrenilabrus, Iunclassified_Pseudocrenilabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudocrenilabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636583;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudocrenilabrus";
}
