namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Crax;

/// <summary>
/// Species: Crax fasciolata
/// NCBI TaxId: 84988
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crax_fasciolata : Crax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crax fasciolata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crax_fasciolata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 84988;
}
