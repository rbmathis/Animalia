using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cotylopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cotylopus.unclassified_Cotylopus;

/// <summary>
/// Abstract class for unclassified Cotylopus (no rank).
/// NCBI TaxId: 2639909
/// </summary>
public abstract class unclassified_Cotylopus : Cotylopus, Iunclassified_Cotylopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cotylopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639909;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cotylopus";
}
