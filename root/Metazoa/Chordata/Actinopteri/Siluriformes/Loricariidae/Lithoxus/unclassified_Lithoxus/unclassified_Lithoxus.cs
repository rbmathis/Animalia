using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lithoxus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Lithoxus.unclassified_Lithoxus;

/// <summary>
/// Abstract class for unclassified Lithoxus (no rank).
/// NCBI TaxId: 3101868
/// </summary>
public abstract class unclassified_Lithoxus : Lithoxus, Iunclassified_Lithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101868;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lithoxus";
}
