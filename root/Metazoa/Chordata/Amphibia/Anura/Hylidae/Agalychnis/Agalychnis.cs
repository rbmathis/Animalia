using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Agalychnis;

/// <summary>
/// Abstract class for Agalychnis (genus).
/// NCBI TaxId: 75989
/// </summary>
public abstract class Agalychnis : Hylidae, IAgalychnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agalychnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75989;

    /// <inheritdoc />
    public virtual string GenusName => "Agalychnis";

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
