using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus.unclassified_Larus;

/// <summary>
/// Abstract class for unclassified Larus (no rank).
/// NCBI TaxId: 3435964
/// </summary>
public abstract class unclassified_Larus : Larus, Iunclassified_Larus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Larus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3435964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Larus";
}
