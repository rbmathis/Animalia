using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astronotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astronotus.unclassified_Astronotus;

/// <summary>
/// Abstract class for unclassified Astronotus (no rank).
/// NCBI TaxId: 2619370
/// </summary>
public abstract class unclassified_Astronotus : Astronotus, Iunclassified_Astronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619370;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astronotus";
}
