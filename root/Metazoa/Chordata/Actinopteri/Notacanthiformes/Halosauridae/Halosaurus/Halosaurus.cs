using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae.Halosaurus;

/// <summary>
/// Abstract class for Halosaurus (genus).
/// NCBI TaxId: 1232748
/// </summary>
public abstract class Halosaurus : Halosauridae, IHalosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1232748;

    /// <inheritdoc />
    public virtual string GenusName => "Halosaurus";

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
