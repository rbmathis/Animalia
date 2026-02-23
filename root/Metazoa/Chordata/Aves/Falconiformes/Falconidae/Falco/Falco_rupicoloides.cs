namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco rupicoloides
/// NCBI TaxId: 148597
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_rupicoloides : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco rupicoloides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_rupicoloides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 148597;
}
