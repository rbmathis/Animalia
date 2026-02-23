using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmorchilus;

/// <summary>
/// Abstract class for Myrmorchilus (genus).
/// NCBI TaxId: 288085
/// </summary>
public abstract class Myrmorchilus : Thamnophilidae, IMyrmorchilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmorchilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288085;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmorchilus";

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
