namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Physeteridae.Physeter;

/// <summary>
/// Species: Physeter macrocephalus
/// NCBI TaxId: 9755
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Physeter_macrocephalus : Physeter
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Physeter macrocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Physeter_macrocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9755;
}
