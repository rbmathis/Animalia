using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Xenentodon;

/// <summary>
/// Abstract class for Xenentodon (genus).
/// NCBI TaxId: 129107
/// </summary>
public abstract class Xenentodon : Belonidae, IXenentodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenentodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129107;

    /// <inheritdoc />
    public virtual string GenusName => "Xenentodon";

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
