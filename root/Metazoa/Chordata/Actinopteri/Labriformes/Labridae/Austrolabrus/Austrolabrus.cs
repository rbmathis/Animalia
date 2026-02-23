using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Austrolabrus;

/// <summary>
/// Abstract class for Austrolabrus (genus).
/// NCBI TaxId: 241265
/// </summary>
public abstract class Austrolabrus : Labridae, IAustrolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241265;

    /// <inheritdoc />
    public virtual string GenusName => "Austrolabrus";

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
