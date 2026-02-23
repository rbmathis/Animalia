using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Clinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Clinus.unclassified_Clinus;

/// <summary>
/// Abstract class for unclassified Clinus (no rank).
/// NCBI TaxId: 2648713
/// </summary>
public abstract class unclassified_Clinus : Clinus, Iunclassified_Clinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648713;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clinus";
}
