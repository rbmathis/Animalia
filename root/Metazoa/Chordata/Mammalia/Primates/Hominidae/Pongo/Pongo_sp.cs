namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pongo;

/// <summary>
/// Species: Pongo sp.
/// NCBI TaxId: 9603
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pongo_sp : Pongo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pongo sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pongo_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9603;
}
