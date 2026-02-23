namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Procyon;

/// <summary>
/// Species: Procyon pygmaeus
/// NCBI TaxId: 2911592
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Procyon_pygmaeus : Procyon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Procyon pygmaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Procyon_pygmaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2911592;
}
