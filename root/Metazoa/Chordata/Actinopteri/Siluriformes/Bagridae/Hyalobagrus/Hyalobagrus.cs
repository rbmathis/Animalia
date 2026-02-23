using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Hyalobagrus;

/// <summary>
/// Abstract class for Hyalobagrus (genus).
/// NCBI TaxId: 337768
/// </summary>
public abstract class Hyalobagrus : Bagridae, IHyalobagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyalobagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337768;

    /// <inheritdoc />
    public virtual string GenusName => "Hyalobagrus";

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
