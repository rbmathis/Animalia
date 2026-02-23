using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Onychodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Onychodactylus.unclassified_Onychodactylus;

/// <summary>
/// Abstract class for unclassified Onychodactylus (no rank).
/// NCBI TaxId: 2633620
/// </summary>
public abstract class unclassified_Onychodactylus : Onychodactylus, Iunclassified_Onychodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Onychodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633620;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Onychodactylus";
}
