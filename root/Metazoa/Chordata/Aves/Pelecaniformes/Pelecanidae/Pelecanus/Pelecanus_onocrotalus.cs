namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Pelecanidae.Pelecanus;

/// <summary>
/// Species: Pelecanus onocrotalus
/// NCBI TaxId: 36301
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelecanus_onocrotalus : Pelecanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelecanus onocrotalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelecanus_onocrotalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36301;
}
