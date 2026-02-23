namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Colibri;

/// <summary>
/// Species: Colibri cyanotus
/// NCBI TaxId: 2744922
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colibri_cyanotus : Colibri
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colibri cyanotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colibri_cyanotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2744922;
}
