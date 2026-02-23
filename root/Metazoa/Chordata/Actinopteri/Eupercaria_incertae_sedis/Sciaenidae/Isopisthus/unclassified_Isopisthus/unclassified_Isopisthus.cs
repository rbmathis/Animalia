using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Isopisthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Isopisthus.unclassified_Isopisthus;

/// <summary>
/// Abstract class for unclassified Isopisthus (no rank).
/// NCBI TaxId: 2642305
/// </summary>
public abstract class unclassified_Isopisthus : Isopisthus, Iunclassified_Isopisthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Isopisthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642305;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Isopisthus";
}
