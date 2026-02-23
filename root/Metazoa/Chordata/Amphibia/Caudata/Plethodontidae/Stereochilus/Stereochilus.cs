using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Stereochilus;

/// <summary>
/// Abstract class for Stereochilus (genus).
/// NCBI TaxId: 269188
/// </summary>
public abstract class Stereochilus : Plethodontidae, IStereochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stereochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269188;

    /// <inheritdoc />
    public virtual string GenusName => "Stereochilus";

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
