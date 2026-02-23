using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pseudoacontias;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pseudoacontias.unclassified_Pseudoacontias;

/// <summary>
/// Abstract class for unclassified Pseudoacontias (no rank).
/// NCBI TaxId: 2973793
/// </summary>
public abstract class unclassified_Pseudoacontias : Pseudoacontias, Iunclassified_Pseudoacontias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoacontias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2973793;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoacontias";
}
