using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae.Pteronotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mormoopidae.Pteronotus.unclassified_Pteronotus;

/// <summary>
/// Abstract class for unclassified Pteronotus (no rank).
/// NCBI TaxId: 2632027
/// </summary>
public abstract class unclassified_Pteronotus : Pteronotus, Iunclassified_Pteronotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pteronotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632027;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pteronotus";
}
