namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Calidris;

/// <summary>
/// Species: Calidris ferruginea
/// NCBI TaxId: 217133
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calidris_ferruginea : Calidris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calidris ferruginea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calidris_ferruginea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 217133;
}
