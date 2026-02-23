using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Haliaeetus;

/// <summary>
/// Abstract class for Haliaeetus (genus).
/// NCBI TaxId: 8968
/// </summary>
public abstract class Haliaeetus : Accipitridae, IHaliaeetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haliaeetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8968;

    /// <inheritdoc />
    public virtual string GenusName => "Haliaeetus";

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
