namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thysochromis;

/// <summary>
/// Species: Thysochromis sp.
/// NCBI TaxId: 97004
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thysochromis_sp : Thysochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thysochromis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thysochromis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 97004;
}
