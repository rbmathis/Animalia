using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Callulops;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Callulops.unclassified_Callulops;

/// <summary>
/// Abstract class for unclassified Callulops (no rank).
/// NCBI TaxId: 2629641
/// </summary>
public abstract class unclassified_Callulops : Callulops, Iunclassified_Callulops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callulops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629641;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callulops";
}
