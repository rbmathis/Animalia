using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauridae.Bathysaurus;

/// <summary>
/// Abstract class for Bathysaurus (genus).
/// NCBI TaxId: 172133
/// </summary>
public abstract class Bathysaurus : Bathysauridae, IBathysaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathysaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172133;

    /// <inheritdoc />
    public virtual string GenusName => "Bathysaurus";

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
