using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Pampus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Pampus.unclassified_Pampus;

/// <summary>
/// Abstract class for unclassified Pampus (no rank).
/// NCBI TaxId: 2637555
/// </summary>
public abstract class unclassified_Pampus : Pampus, Iunclassified_Pampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637555;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pampus";
}
