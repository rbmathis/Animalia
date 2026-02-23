using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Spinipterus;

/// <summary>
/// Abstract class for Spinipterus (genus).
/// NCBI TaxId: 2382294
/// </summary>
public abstract class Spinipterus : Auchenipteridae, ISpinipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spinipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2382294;

    /// <inheritdoc />
    public virtual string GenusName => "Spinipterus";

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
