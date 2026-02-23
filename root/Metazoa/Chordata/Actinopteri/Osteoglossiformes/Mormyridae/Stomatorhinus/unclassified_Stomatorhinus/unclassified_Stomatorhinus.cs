using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Stomatorhinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Stomatorhinus.unclassified_Stomatorhinus;

/// <summary>
/// Abstract class for unclassified Stomatorhinus (no rank).
/// NCBI TaxId: 2634920
/// </summary>
public abstract class unclassified_Stomatorhinus : Stomatorhinus, Iunclassified_Stomatorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stomatorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634920;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stomatorhinus";
}
