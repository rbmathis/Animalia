namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis;

/// <summary>
/// Species: Agapornis roseicollis
/// NCBI TaxId: 60468
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agapornis_roseicollis : Agapornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agapornis roseicollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agapornis_roseicollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 60468;
}
