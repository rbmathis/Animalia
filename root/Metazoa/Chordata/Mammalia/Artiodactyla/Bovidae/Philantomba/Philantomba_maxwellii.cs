namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Philantomba;

/// <summary>
/// Species: Philantomba maxwellii
/// NCBI TaxId: 907741
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Philantomba_maxwellii : Philantomba
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Philantomba maxwellii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Philantomba_maxwellii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 907741;
}
