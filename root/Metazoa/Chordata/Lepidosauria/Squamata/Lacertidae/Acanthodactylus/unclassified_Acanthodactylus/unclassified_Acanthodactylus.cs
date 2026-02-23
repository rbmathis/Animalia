using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Acanthodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Acanthodactylus.unclassified_Acanthodactylus;

/// <summary>
/// Abstract class for unclassified Acanthodactylus (no rank).
/// NCBI TaxId: 2637366
/// </summary>
public abstract class unclassified_Acanthodactylus : Acanthodactylus, Iunclassified_Acanthodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637366;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthodactylus";
}
