namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Homo;

/// <summary>
/// Species: Homo sapiens
/// NCBI TaxId: 9606
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homo_sapiens : Homo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homo sapiens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homo_sapiens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9606;
}
