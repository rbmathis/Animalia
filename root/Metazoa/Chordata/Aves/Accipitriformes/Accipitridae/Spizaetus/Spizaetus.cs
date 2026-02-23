using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Spizaetus;

/// <summary>
/// Abstract class for Spizaetus (genus).
/// NCBI TaxId: 214437
/// </summary>
public abstract class Spizaetus : Accipitridae, ISpizaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spizaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214437;

    /// <inheritdoc />
    public virtual string GenusName => "Spizaetus";

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
