using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Elapidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Elapidae_incertae_sedis.Aspidelaps;

/// <summary>
/// Abstract class for Aspidelaps (genus).
/// NCBI TaxId: 8606
/// </summary>
public abstract class Aspidelaps : Elapidae_incertae_sedis, IAspidelaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidelaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8606;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidelaps";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
