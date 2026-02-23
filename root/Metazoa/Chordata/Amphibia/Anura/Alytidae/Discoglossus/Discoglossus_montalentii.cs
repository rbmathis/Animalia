namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Discoglossus;

/// <summary>
/// Species: Discoglossus montalentii
/// NCBI TaxId: 191473
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Discoglossus_montalentii : Discoglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Discoglossus montalentii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Discoglossus_montalentii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 191473;
}
