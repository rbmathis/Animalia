namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Ochromyscus;

/// <summary>
/// Species: Ochromyscus niveiventris
/// NCBI TaxId: 3370441
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ochromyscus_niveiventris : Ochromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ochromyscus niveiventris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ochromyscus_niveiventris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370441;
}
