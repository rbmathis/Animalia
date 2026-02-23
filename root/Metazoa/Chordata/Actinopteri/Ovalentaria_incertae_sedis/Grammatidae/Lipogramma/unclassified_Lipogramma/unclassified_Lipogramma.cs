using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Grammatidae.Lipogramma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Grammatidae.Lipogramma.unclassified_Lipogramma;

/// <summary>
/// Abstract class for unclassified Lipogramma (no rank).
/// NCBI TaxId: 2620527
/// </summary>
public abstract class unclassified_Lipogramma : Lipogramma, Iunclassified_Lipogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lipogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620527;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lipogramma";
}
