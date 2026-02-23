using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa.unclassified_Tringa;

/// <summary>
/// Abstract class for unclassified Tringa (no rank).
/// NCBI TaxId: 2625771
/// </summary>
public abstract class unclassified_Tringa : Tringa, Iunclassified_Tringa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tringa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625771;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tringa";
}
