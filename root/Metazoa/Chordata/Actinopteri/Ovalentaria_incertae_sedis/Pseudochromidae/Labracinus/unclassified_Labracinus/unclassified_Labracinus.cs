using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Labracinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Labracinus.unclassified_Labracinus;

/// <summary>
/// Abstract class for unclassified Labracinus (no rank).
/// NCBI TaxId: 2640201
/// </summary>
public abstract class unclassified_Labracinus : Labracinus, Iunclassified_Labracinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labracinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640201;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labracinus";
}
