using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Hemisilurus;

/// <summary>
/// Abstract class for Hemisilurus (genus).
/// NCBI TaxId: 337671
/// </summary>
public abstract class Hemisilurus : Siluridae, IHemisilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemisilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337671;

    /// <inheritdoc />
    public virtual string GenusName => "Hemisilurus";

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
