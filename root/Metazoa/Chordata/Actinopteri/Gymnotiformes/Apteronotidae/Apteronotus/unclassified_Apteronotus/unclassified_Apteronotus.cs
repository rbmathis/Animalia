using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Apteronotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Apteronotus.unclassified_Apteronotus;

/// <summary>
/// Abstract class for unclassified Apteronotus (no rank).
/// NCBI TaxId: 2625173
/// </summary>
public abstract class unclassified_Apteronotus : Apteronotus, Iunclassified_Apteronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apteronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625173;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apteronotus";
}
