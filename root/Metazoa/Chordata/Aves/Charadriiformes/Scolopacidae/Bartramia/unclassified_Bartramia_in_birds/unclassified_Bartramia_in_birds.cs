using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Bartramia;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Bartramia.unclassified_Bartramia_in_birds;

/// <summary>
/// Abstract class for unclassified Bartramia (in: birds) (no rank).
/// NCBI TaxId: 2677047
/// </summary>
public abstract class unclassified_Bartramia_in_birds : Bartramia, Iunclassified_Bartramia_in_birds
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bartramia (in: birds)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677047;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bartramia_in_birds";
}
