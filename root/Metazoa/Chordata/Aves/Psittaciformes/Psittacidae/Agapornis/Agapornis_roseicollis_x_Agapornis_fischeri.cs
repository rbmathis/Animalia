namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis;

/// <summary>
/// Species: Agapornis roseicollis x Agapornis fischeri
/// NCBI TaxId: 3046999
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agapornis_roseicollis_x_Agapornis_fischeri : Agapornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agapornis roseicollis x Agapornis fischeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agapornis_roseicollis_x_Agapornis_fischeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3046999;
}
