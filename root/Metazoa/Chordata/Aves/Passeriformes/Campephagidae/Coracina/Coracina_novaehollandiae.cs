namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Coracina;

/// <summary>
/// Species: Coracina novaehollandiae
/// NCBI TaxId: 254452
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracina_novaehollandiae : Coracina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracina novaehollandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracina_novaehollandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 254452;
}
