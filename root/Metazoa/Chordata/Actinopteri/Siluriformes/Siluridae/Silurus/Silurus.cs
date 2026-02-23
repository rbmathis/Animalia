using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Silurus;

/// <summary>
/// Abstract class for Silurus (genus).
/// NCBI TaxId: 94992
/// </summary>
public abstract class Silurus : Siluridae, ISilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94992;

    /// <inheritdoc />
    public virtual string GenusName => "Silurus";

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
