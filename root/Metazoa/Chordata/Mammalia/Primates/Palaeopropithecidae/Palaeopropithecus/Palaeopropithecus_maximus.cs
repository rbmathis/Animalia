namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae.Palaeopropithecus;

/// <summary>
/// Species: Palaeopropithecus maximus
/// NCBI TaxId: 1597978
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Palaeopropithecus_maximus : Palaeopropithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Palaeopropithecus maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Palaeopropithecus_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1597978;
}
