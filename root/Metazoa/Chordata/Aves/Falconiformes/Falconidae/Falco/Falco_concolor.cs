namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco concolor
/// NCBI TaxId: 495947
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_concolor : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco concolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_concolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 495947;
}
