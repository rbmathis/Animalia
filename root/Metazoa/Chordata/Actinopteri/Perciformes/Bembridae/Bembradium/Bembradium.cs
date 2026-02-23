using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembridae.Bembradium;

/// <summary>
/// Abstract class for Bembradium (genus).
/// NCBI TaxId: 1306748
/// </summary>
public abstract class Bembradium : Bembridae, IBembradium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bembradium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306748;

    /// <inheritdoc />
    public virtual string GenusName => "Bembradium";

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
