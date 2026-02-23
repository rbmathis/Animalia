using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Nisaetus;

/// <summary>
/// Abstract class for Nisaetus (genus).
/// NCBI TaxId: 433377
/// </summary>
public abstract class Nisaetus : Accipitridae, INisaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nisaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 433377;

    /// <inheritdoc />
    public virtual string GenusName => "Nisaetus";

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
