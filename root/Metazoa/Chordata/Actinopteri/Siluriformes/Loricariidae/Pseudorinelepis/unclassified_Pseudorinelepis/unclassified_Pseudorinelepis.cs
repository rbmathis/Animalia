using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudorinelepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudorinelepis.unclassified_Pseudorinelepis;

/// <summary>
/// Abstract class for unclassified Pseudorinelepis (no rank).
/// NCBI TaxId: 2634949
/// </summary>
public abstract class unclassified_Pseudorinelepis : Pseudorinelepis, Iunclassified_Pseudorinelepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudorinelepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634949;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudorinelepis";
}
