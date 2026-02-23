namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Parancistrus;

/// <summary>
/// Species: Parancistrus aurantiacus
/// NCBI TaxId: 52088
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parancistrus_aurantiacus : Parancistrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parancistrus aurantiacus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parancistrus_aurantiacus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52088;
}
