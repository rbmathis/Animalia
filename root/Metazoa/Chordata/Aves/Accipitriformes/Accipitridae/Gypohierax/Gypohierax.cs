using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Gypohierax;

/// <summary>
/// Abstract class for Gypohierax (genus).
/// NCBI TaxId: 321073
/// </summary>
public abstract class Gypohierax : Accipitridae, IGypohierax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gypohierax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321073;

    /// <inheritdoc />
    public virtual string GenusName => "Gypohierax";

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
