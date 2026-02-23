using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmoborus;

/// <summary>
/// Abstract class for Myrmoborus (genus).
/// NCBI TaxId: 288069
/// </summary>
public abstract class Myrmoborus : Thamnophilidae, IMyrmoborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmoborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288069;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmoborus";

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
