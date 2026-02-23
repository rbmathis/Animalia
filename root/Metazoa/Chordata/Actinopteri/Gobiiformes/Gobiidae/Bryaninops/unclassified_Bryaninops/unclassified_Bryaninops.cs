using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bryaninops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bryaninops.unclassified_Bryaninops;

/// <summary>
/// Abstract class for unclassified Bryaninops (no rank).
/// NCBI TaxId: 2625045
/// </summary>
public abstract class unclassified_Bryaninops : Bryaninops, Iunclassified_Bryaninops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bryaninops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625045;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bryaninops";
}
