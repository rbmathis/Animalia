namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Calyptura;

/// <summary>
/// Species: Calyptura cristata
/// NCBI TaxId: 1178543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calyptura_cristata : Calyptura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calyptura cristata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calyptura_cristata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1178543;
}
