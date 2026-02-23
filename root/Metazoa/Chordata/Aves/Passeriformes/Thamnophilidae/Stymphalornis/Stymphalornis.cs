using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Stymphalornis;

/// <summary>
/// Abstract class for Stymphalornis (genus).
/// NCBI TaxId: 1530397
/// </summary>
public abstract class Stymphalornis : Thamnophilidae, IStymphalornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stymphalornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1530397;

    /// <inheritdoc />
    public virtual string GenusName => "Stymphalornis";

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
