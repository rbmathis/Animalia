namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ranitomeya;

/// <summary>
/// Species: Ranitomeya sp. 'Supata'
/// NCBI TaxId: 1091404
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ranitomeya_sp_Supata : Ranitomeya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ranitomeya sp. 'Supata'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ranitomeya_sp_Supata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1091404;
}
