namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pseudochromis;

/// <summary>
/// Species: Pseudochromis sp.
/// NCBI TaxId: 3446945
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudochromis_sp : Pseudochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudochromis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudochromis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3446945;
}
