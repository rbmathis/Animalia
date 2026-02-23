namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Geochelone;

/// <summary>
/// Species: Geochelone platynota
/// NCBI TaxId: 286019
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geochelone_platynota : Geochelone
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geochelone platynota";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geochelone_platynota";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286019;
}
