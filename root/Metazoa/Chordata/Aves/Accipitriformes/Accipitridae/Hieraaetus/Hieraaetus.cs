using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Hieraaetus;

/// <summary>
/// Abstract class for Hieraaetus (genus).
/// NCBI TaxId: 70274
/// </summary>
public abstract class Hieraaetus : Accipitridae, IHieraaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hieraaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70274;

    /// <inheritdoc />
    public virtual string GenusName => "Hieraaetus";

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
