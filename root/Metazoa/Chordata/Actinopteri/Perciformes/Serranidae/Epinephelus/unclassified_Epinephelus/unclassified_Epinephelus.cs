using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelus.unclassified_Epinephelus;

/// <summary>
/// Abstract class for unclassified Epinephelus (no rank).
/// NCBI TaxId: 2633003
/// </summary>
public abstract class unclassified_Epinephelus : Epinephelus, Iunclassified_Epinephelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epinephelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633003;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epinephelus";
}
