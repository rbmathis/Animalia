using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiasciurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiasciurus.unclassified_Tamiasciurus;

/// <summary>
/// Abstract class for unclassified Tamiasciurus (no rank).
/// NCBI TaxId: 2618603
/// </summary>
public abstract class unclassified_Tamiasciurus : Tamiasciurus, Iunclassified_Tamiasciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tamiasciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618603;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tamiasciurus";
}
