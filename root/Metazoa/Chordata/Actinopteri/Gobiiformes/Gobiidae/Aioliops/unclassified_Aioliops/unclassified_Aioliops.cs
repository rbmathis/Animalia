using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Aioliops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Aioliops.unclassified_Aioliops;

/// <summary>
/// Abstract class for unclassified Aioliops (no rank).
/// NCBI TaxId: 2629341
/// </summary>
public abstract class unclassified_Aioliops : Aioliops, Iunclassified_Aioliops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aioliops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629341;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aioliops";
}
