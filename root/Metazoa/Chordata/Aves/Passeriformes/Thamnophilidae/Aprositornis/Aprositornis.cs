using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Aprositornis;

/// <summary>
/// Abstract class for Aprositornis (genus).
/// NCBI TaxId: 2765000
/// </summary>
public abstract class Aprositornis : Thamnophilidae, IAprositornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aprositornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2765000;

    /// <inheritdoc />
    public virtual string GenusName => "Aprositornis";

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
