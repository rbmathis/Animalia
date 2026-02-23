using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae.Laiopteryx;

/// <summary>
/// Abstract class for Laiopteryx (genus).
/// NCBI TaxId: 3228763
/// </summary>
public abstract class Laiopteryx : Citharidae, ILaiopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laiopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3228763;

    /// <inheritdoc />
    public virtual string GenusName => "Laiopteryx";

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
