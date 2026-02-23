using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Poliocrania;

/// <summary>
/// Abstract class for Poliocrania (genus).
/// NCBI TaxId: 2767940
/// </summary>
public abstract class Poliocrania : Thamnophilidae, IPoliocrania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poliocrania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767940;

    /// <inheritdoc />
    public virtual string GenusName => "Poliocrania";

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
