using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Stephanoaetus;

/// <summary>
/// Abstract class for Stephanoaetus (genus).
/// NCBI TaxId: 252801
/// </summary>
public abstract class Stephanoaetus : Accipitridae, IStephanoaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stephanoaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 252801;

    /// <inheritdoc />
    public virtual string GenusName => "Stephanoaetus";

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
