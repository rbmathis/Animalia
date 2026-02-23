using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Mixcoatlus;

/// <summary>
/// Abstract class for Mixcoatlus (genus).
/// NCBI TaxId: 1331661
/// </summary>
public abstract class Mixcoatlus : Viperidae, IMixcoatlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mixcoatlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1331661;

    /// <inheritdoc />
    public virtual string GenusName => "Mixcoatlus";

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
