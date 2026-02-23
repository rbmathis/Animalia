using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tor;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tor.unclassified_Tor;

/// <summary>
/// Abstract class for unclassified Tor (no rank).
/// NCBI TaxId: 2643369
/// </summary>
public abstract class unclassified_Tor : Tor, Iunclassified_Tor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643369;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tor";
}
