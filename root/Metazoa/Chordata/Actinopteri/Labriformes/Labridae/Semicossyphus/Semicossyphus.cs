using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Semicossyphus;

/// <summary>
/// Abstract class for Semicossyphus (genus).
/// NCBI TaxId: 241345
/// </summary>
public abstract class Semicossyphus : Labridae, ISemicossyphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Semicossyphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241345;

    /// <inheritdoc />
    public virtual string GenusName => "Semicossyphus";

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
