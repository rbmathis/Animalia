using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos.unclassified_Bos;

/// <summary>
/// Abstract class for unclassified Bos (no rank).
/// NCBI TaxId: 2630088
/// </summary>
public abstract class unclassified_Bos : Bos, Iunclassified_Bos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630088;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bos";
}
