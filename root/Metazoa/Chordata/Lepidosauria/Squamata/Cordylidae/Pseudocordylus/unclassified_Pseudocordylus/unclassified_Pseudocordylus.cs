using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Pseudocordylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Pseudocordylus.unclassified_Pseudocordylus;

/// <summary>
/// Abstract class for unclassified Pseudocordylus (no rank).
/// NCBI TaxId: 2630122
/// </summary>
public abstract class unclassified_Pseudocordylus : Pseudocordylus, Iunclassified_Pseudocordylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudocordylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630122;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudocordylus";
}
