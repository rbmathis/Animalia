using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmotherula;

/// <summary>
/// Abstract class for Myrmotherula (genus).
/// NCBI TaxId: 88176
/// </summary>
public abstract class Myrmotherula : Thamnophilidae, IMyrmotherula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmotherula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88176;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmotherula";

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
