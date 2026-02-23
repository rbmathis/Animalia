using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae.Hemibelideus;

/// <summary>
/// Abstract class for Hemibelideus (genus).
/// NCBI TaxId: 596255
/// </summary>
public abstract class Hemibelideus : Pseudocheiridae, IHemibelideus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemibelideus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 596255;

    /// <inheritdoc />
    public virtual string GenusName => "Hemibelideus";

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
