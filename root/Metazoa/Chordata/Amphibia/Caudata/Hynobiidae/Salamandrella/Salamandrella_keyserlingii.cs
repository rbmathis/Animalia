namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Salamandrella;

/// <summary>
/// Species: Salamandrella keyserlingii
/// NCBI TaxId: 288315
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salamandrella_keyserlingii : Salamandrella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salamandrella keyserlingii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salamandrella_keyserlingii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 288315;
}
