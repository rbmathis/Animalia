using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Hemibagrus;

/// <summary>
/// Abstract class for Hemibagrus (genus).
/// NCBI TaxId: 156982
/// </summary>
public abstract class Hemibagrus : Bagridae, IHemibagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemibagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156982;

    /// <inheritdoc />
    public virtual string GenusName => "Hemibagrus";

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
