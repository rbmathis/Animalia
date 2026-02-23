using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Astrapogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Astrapogon.unclassified_Astrapogon;

/// <summary>
/// Abstract class for unclassified Astrapogon (no rank).
/// NCBI TaxId: 2620107
/// </summary>
public abstract class unclassified_Astrapogon : Astrapogon, Iunclassified_Astrapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astrapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620107;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astrapogon";
}
