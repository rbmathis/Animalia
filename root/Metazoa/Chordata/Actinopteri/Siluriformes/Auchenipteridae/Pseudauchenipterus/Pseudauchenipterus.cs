using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Pseudauchenipterus;

/// <summary>
/// Abstract class for Pseudauchenipterus (genus).
/// NCBI TaxId: 2382291
/// </summary>
public abstract class Pseudauchenipterus : Auchenipteridae, IPseudauchenipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudauchenipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2382291;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudauchenipterus";

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
