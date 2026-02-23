using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Funisciurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Funisciurus.unclassified_Funisciurus;

/// <summary>
/// Abstract class for unclassified Funisciurus (no rank).
/// NCBI TaxId: 2626095
/// </summary>
public abstract class unclassified_Funisciurus : Funisciurus, Iunclassified_Funisciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Funisciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Funisciurus";
}
