namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Discoglossus;

/// <summary>
/// Species: Discoglossus pictus
/// NCBI TaxId: 8351
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Discoglossus_pictus : Discoglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Discoglossus pictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Discoglossus_pictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8351;
}
