namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis;

/// <summary>
/// Species: Agapornis lilianae x Agapornis fischeri
/// NCBI TaxId: 3047000
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agapornis_lilianae_x_Agapornis_fischeri : Agapornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agapornis lilianae x Agapornis fischeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agapornis_lilianae_x_Agapornis_fischeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3047000;
}
