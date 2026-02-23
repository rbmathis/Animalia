using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Hylomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Hylomys.unclassified_Hylomys;

/// <summary>
/// Abstract class for unclassified Hylomys (no rank).
/// NCBI TaxId: 2637714
/// </summary>
public abstract class unclassified_Hylomys : Hylomys, Iunclassified_Hylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637714;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hylomys";
}
