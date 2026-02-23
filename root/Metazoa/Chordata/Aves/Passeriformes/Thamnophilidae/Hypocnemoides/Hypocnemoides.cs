using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Hypocnemoides;

/// <summary>
/// Abstract class for Hypocnemoides (genus).
/// NCBI TaxId: 288095
/// </summary>
public abstract class Hypocnemoides : Thamnophilidae, IHypocnemoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypocnemoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288095;

    /// <inheritdoc />
    public virtual string GenusName => "Hypocnemoides";

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
