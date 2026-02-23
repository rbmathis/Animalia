using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites.unclassified_Oceanites;

/// <summary>
/// Abstract class for unclassified Oceanites (no rank).
/// NCBI TaxId: 3342346
/// </summary>
public abstract class unclassified_Oceanites : Oceanites, Iunclassified_Oceanites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oceanites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3342346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oceanites";
}
