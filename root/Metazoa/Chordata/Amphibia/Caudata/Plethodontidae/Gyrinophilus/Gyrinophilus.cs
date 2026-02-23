using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Gyrinophilus;

/// <summary>
/// Abstract class for Gyrinophilus (genus).
/// NCBI TaxId: 134759
/// </summary>
public abstract class Gyrinophilus : Plethodontidae, IGyrinophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gyrinophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 134759;

    /// <inheritdoc />
    public virtual string GenusName => "Gyrinophilus";

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
