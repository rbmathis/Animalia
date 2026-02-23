namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Lanius;

/// <summary>
/// Species: Lanius bucephalus x Lanius cristatus superciliosus
/// NCBI TaxId: 3025127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lanius_bucephalus_x_Lanius_cristatus_superciliosus : Lanius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lanius bucephalus x Lanius cristatus superciliosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lanius_bucephalus_x_Lanius_cristatus_superciliosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3025127;
}
