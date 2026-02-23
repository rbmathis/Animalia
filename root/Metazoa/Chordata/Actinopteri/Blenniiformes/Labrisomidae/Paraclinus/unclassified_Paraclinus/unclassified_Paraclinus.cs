using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Paraclinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Paraclinus.unclassified_Paraclinus;

/// <summary>
/// Abstract class for unclassified Paraclinus (no rank).
/// NCBI TaxId: 2636312
/// </summary>
public abstract class unclassified_Paraclinus : Paraclinus, Iunclassified_Paraclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636312;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraclinus";
}
