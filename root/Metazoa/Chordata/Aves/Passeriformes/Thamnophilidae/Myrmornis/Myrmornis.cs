using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmornis;

/// <summary>
/// Abstract class for Myrmornis (genus).
/// NCBI TaxId: 255382
/// </summary>
public abstract class Myrmornis : Thamnophilidae, IMyrmornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255382;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmornis";

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
