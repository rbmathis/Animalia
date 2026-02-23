using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Arenaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Arenaria.unclassified_Arenaria_in_birds;

/// <summary>
/// Abstract class for unclassified Arenaria (in: birds) (no rank).
/// NCBI TaxId: 2677019
/// </summary>
public abstract class unclassified_Arenaria_in_birds : Arenaria, Iunclassified_Arenaria_in_birds
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arenaria (in: birds)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677019;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arenaria_in_birds";
}
