using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudolabrus;

/// <summary>
/// Abstract class for Pseudolabrus (genus).
/// NCBI TaxId: 83879
/// </summary>
public abstract class Pseudolabrus : Labridae, IPseudolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83879;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudolabrus";

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
