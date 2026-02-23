using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Starksia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Starksia.unclassified_Starksia;

/// <summary>
/// Abstract class for unclassified Starksia (no rank).
/// NCBI TaxId: 2620451
/// </summary>
public abstract class unclassified_Starksia : Starksia, Iunclassified_Starksia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Starksia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620451;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Starksia";
}
