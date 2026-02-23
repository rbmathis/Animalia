using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Sibynophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Sibynophis.unclassified_Sibynophis;

/// <summary>
/// Abstract class for unclassified Sibynophis (no rank).
/// NCBI TaxId: 2795766
/// </summary>
public abstract class unclassified_Sibynophis : Sibynophis, Iunclassified_Sibynophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sibynophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2795766;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sibynophis";
}
