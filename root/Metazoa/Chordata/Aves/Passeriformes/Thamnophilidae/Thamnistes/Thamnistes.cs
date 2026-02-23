using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Thamnistes;

/// <summary>
/// Abstract class for Thamnistes (genus).
/// NCBI TaxId: 288063
/// </summary>
public abstract class Thamnistes : Thamnophilidae, IThamnistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288063;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnistes";

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
