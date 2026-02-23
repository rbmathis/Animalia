using AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Branchiostoma;

/// <summary>
/// Abstract class for Branchiostoma (genus).
/// NCBI TaxId: 7737
/// </summary>
public abstract class Branchiostoma : Branchiostomatidae, IBranchiostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Branchiostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7737;

    /// <inheritdoc />
    public virtual string GenusName => "Branchiostoma";

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
