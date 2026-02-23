using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Tocantinsia;

/// <summary>
/// Abstract class for Tocantinsia (genus).
/// NCBI TaxId: 1594725
/// </summary>
public abstract class Tocantinsia : Auchenipteridae, ITocantinsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tocantinsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1594725;

    /// <inheritdoc />
    public virtual string GenusName => "Tocantinsia";

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
