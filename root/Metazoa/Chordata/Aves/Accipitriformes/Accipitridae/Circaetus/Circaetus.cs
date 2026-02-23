using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Circaetus;

/// <summary>
/// Abstract class for Circaetus (genus).
/// NCBI TaxId: 43464
/// </summary>
public abstract class Circaetus : Accipitridae, ICircaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Circaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43464;

    /// <inheritdoc />
    public virtual string GenusName => "Circaetus";

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
