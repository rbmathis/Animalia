using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hasemania;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hasemania.unclassified_Hasemania;

/// <summary>
/// Abstract class for unclassified Hasemania (no rank).
/// NCBI TaxId: 2626440
/// </summary>
public abstract class unclassified_Hasemania : Hasemania, Iunclassified_Hasemania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hasemania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626440;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hasemania";
}
