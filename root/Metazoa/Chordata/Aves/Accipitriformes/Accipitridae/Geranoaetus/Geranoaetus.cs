using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Geranoaetus;

/// <summary>
/// Abstract class for Geranoaetus (genus).
/// NCBI TaxId: 223772
/// </summary>
public abstract class Geranoaetus : Accipitridae, IGeranoaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geranoaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223772;

    /// <inheritdoc />
    public virtual string GenusName => "Geranoaetus";

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
