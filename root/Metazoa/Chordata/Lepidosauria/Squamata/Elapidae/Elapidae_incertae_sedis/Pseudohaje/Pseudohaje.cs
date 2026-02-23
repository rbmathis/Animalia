using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Elapidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Elapidae_incertae_sedis.Pseudohaje;

/// <summary>
/// Abstract class for Pseudohaje (genus).
/// NCBI TaxId: 1545502
/// </summary>
public abstract class Pseudohaje : Elapidae_incertae_sedis, IPseudohaje
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudohaje";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545502;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudohaje";

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
