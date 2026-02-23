using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Cycleptus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Cycleptus.unclassified_Cycleptus;

/// <summary>
/// Abstract class for unclassified Cycleptus (no rank).
/// NCBI TaxId: 2632624
/// </summary>
public abstract class unclassified_Cycleptus : Cycleptus, Iunclassified_Cycleptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cycleptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632624;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cycleptus";
}
