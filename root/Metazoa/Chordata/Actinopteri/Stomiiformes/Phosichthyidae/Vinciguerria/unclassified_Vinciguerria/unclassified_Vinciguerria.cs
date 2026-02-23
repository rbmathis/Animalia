using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Vinciguerria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Vinciguerria.unclassified_Vinciguerria;

/// <summary>
/// Abstract class for unclassified Vinciguerria (no rank).
/// NCBI TaxId: 2638966
/// </summary>
public abstract class unclassified_Vinciguerria : Vinciguerria, Iunclassified_Vinciguerria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Vinciguerria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638966;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Vinciguerria";
}
