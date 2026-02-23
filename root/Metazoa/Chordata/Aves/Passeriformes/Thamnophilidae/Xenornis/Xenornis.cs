using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Xenornis;

/// <summary>
/// Abstract class for Xenornis (genus).
/// NCBI TaxId: 1118854
/// </summary>
public abstract class Xenornis : Thamnophilidae, IXenornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118854;

    /// <inheritdoc />
    public virtual string GenusName => "Xenornis";

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
