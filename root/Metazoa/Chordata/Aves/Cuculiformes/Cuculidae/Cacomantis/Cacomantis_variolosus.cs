namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cacomantis;

/// <summary>
/// Species: Cacomantis variolosus
/// NCBI TaxId: 121386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacomantis_variolosus : Cacomantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacomantis variolosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacomantis_variolosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121386;
}
