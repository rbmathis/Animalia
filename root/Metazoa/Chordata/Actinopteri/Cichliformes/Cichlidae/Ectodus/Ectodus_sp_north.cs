namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ectodus;

/// <summary>
/// Species: Ectodus sp. 'north'
/// NCBI TaxId: 1818571
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ectodus_sp_north : Ectodus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ectodus sp. 'north'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ectodus_sp_north";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1818571;
}
