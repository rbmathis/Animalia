using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Typhlops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Typhlops.unclassified_Typhlops;

/// <summary>
/// Abstract class for unclassified Typhlops (no rank).
/// NCBI TaxId: 2649524
/// </summary>
public abstract class unclassified_Typhlops : Typhlops, Iunclassified_Typhlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Typhlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649524;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Typhlops";
}
