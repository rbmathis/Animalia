namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

/// <summary>
/// Species: Salmo letnica
/// NCBI TaxId: 234793
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salmo_letnica : Salmo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salmo letnica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salmo_letnica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 234793;
}
