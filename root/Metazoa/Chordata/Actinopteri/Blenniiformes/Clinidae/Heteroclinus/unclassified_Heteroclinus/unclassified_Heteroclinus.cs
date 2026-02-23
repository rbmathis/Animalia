using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Heteroclinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Heteroclinus.unclassified_Heteroclinus;

/// <summary>
/// Abstract class for unclassified Heteroclinus (no rank).
/// NCBI TaxId: 2636070
/// </summary>
public abstract class unclassified_Heteroclinus : Heteroclinus, Iunclassified_Heteroclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heteroclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636070;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heteroclinus";
}
