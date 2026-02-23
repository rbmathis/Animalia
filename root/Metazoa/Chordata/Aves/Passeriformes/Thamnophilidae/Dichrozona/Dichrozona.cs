using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Dichrozona;

/// <summary>
/// Abstract class for Dichrozona (genus).
/// NCBI TaxId: 288089
/// </summary>
public abstract class Dichrozona : Thamnophilidae, IDichrozona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dichrozona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288089;

    /// <inheritdoc />
    public virtual string GenusName => "Dichrozona";

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
