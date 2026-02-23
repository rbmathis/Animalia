using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Calamaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Calamaria.unclassified_Calamaria;

/// <summary>
/// Abstract class for unclassified Calamaria (no rank).
/// NCBI TaxId: 2816391
/// </summary>
public abstract class unclassified_Calamaria : Calamaria, Iunclassified_Calamaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calamaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2816391;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calamaria";
}
