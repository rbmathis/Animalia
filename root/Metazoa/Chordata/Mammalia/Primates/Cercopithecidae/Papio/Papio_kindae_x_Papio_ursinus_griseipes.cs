namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

/// <summary>
/// Species: Papio kindae x Papio ursinus griseipes
/// NCBI TaxId: 1945559
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papio_kindae_x_Papio_ursinus_griseipes : Papio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papio kindae x Papio ursinus griseipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papio_kindae_x_Papio_ursinus_griseipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1945559;
}
