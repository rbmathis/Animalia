using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Polemaetus;

/// <summary>
/// Abstract class for Polemaetus (genus).
/// NCBI TaxId: 252793
/// </summary>
public abstract class Polemaetus : Accipitridae, IPolemaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polemaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 252793;

    /// <inheritdoc />
    public virtual string GenusName => "Polemaetus";

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
