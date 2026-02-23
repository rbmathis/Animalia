using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Neosynchiropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Neosynchiropus.unclassified_Neosynchiropus;

/// <summary>
/// Abstract class for unclassified Neosynchiropus (no rank).
/// NCBI TaxId: 2630256
/// </summary>
public abstract class unclassified_Neosynchiropus : Neosynchiropus, Iunclassified_Neosynchiropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neosynchiropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630256;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neosynchiropus";
}
