namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Pyxis;

/// <summary>
/// Species: Pyxis planicauda
/// NCBI TaxId: 66193
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyxis_planicauda : Pyxis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyxis planicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyxis_planicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66193;
}
