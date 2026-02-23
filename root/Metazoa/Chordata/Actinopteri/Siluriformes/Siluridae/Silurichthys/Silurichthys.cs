using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Silurichthys;

/// <summary>
/// Abstract class for Silurichthys (genus).
/// NCBI TaxId: 337713
/// </summary>
public abstract class Silurichthys : Siluridae, ISilurichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silurichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337713;

    /// <inheritdoc />
    public virtual string GenusName => "Silurichthys";

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
