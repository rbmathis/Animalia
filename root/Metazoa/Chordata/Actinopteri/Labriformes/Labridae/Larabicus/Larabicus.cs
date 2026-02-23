using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Larabicus;

/// <summary>
/// Abstract class for Larabicus (genus).
/// NCBI TaxId: 241313
/// </summary>
public abstract class Larabicus : Labridae, ILarabicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Larabicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241313;

    /// <inheritdoc />
    public virtual string GenusName => "Larabicus";

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
