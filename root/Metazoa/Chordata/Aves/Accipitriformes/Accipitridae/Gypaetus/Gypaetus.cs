using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Gypaetus;

/// <summary>
/// Abstract class for Gypaetus (genus).
/// NCBI TaxId: 33609
/// </summary>
public abstract class Gypaetus : Accipitridae, IGypaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gypaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33609;

    /// <inheritdoc />
    public virtual string GenusName => "Gypaetus";

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
