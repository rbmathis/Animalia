using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Melierax;

/// <summary>
/// Abstract class for Melierax (genus).
/// NCBI TaxId: 321114
/// </summary>
public abstract class Melierax : Accipitridae, IMelierax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melierax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321114;

    /// <inheritdoc />
    public virtual string GenusName => "Melierax";

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
