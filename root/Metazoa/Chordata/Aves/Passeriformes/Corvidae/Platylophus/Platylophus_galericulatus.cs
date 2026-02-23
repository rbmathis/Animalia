namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Platylophus;

/// <summary>
/// Species: Platylophus galericulatus
/// NCBI TaxId: 205797
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platylophus_galericulatus : Platylophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platylophus galericulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platylophus_galericulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 205797;
}
