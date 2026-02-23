using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pseudotolithus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pseudotolithus.unclassified_Pseudotolithus;

/// <summary>
/// Abstract class for unclassified Pseudotolithus (no rank).
/// NCBI TaxId: 2623731
/// </summary>
public abstract class unclassified_Pseudotolithus : Pseudotolithus, Iunclassified_Pseudotolithus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudotolithus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudotolithus";
}
