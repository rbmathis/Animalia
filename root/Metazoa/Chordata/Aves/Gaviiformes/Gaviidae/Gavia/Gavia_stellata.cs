namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gaviiformes.Gaviidae.Gavia;

/// <summary>
/// Species: Gavia stellata
/// NCBI TaxId: 37040
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gavia_stellata : Gavia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gavia stellata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gavia_stellata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37040;
}
