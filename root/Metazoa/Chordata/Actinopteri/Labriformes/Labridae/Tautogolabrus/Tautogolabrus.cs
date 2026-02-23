using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Tautogolabrus;

/// <summary>
/// Abstract class for Tautogolabrus (genus).
/// NCBI TaxId: 34786
/// </summary>
public abstract class Tautogolabrus : Labridae, ITautogolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tautogolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34786;

    /// <inheritdoc />
    public virtual string GenusName => "Tautogolabrus";

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
