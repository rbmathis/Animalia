using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mchenga;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mchenga.unclassified_Mchenga;

/// <summary>
/// Abstract class for unclassified Mchenga (no rank).
/// NCBI TaxId: 3075815
/// </summary>
public abstract class unclassified_Mchenga : Mchenga, Iunclassified_Mchenga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mchenga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3075815;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mchenga";
}
