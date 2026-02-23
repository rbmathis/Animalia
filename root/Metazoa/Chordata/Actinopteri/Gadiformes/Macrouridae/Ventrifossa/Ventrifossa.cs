using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Ventrifossa;

/// <summary>
/// Abstract class for Ventrifossa (genus).
/// NCBI TaxId: 332669
/// </summary>
public abstract class Ventrifossa : Macrouridae, IVentrifossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ventrifossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 332669;

    /// <inheritdoc />
    public virtual string GenusName => "Ventrifossa";

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
