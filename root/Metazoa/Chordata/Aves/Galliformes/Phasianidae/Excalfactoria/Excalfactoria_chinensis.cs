namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Excalfactoria;

/// <summary>
/// Species: Excalfactoria chinensis
/// NCBI TaxId: 46218
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Excalfactoria_chinensis : Excalfactoria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Excalfactoria chinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Excalfactoria_chinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46218;
}
