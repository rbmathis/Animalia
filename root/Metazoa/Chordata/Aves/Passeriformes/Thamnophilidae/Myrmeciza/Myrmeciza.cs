using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmeciza;

/// <summary>
/// Abstract class for Myrmeciza (genus).
/// NCBI TaxId: 288071
/// </summary>
public abstract class Myrmeciza : Thamnophilidae, IMyrmeciza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmeciza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288071;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmeciza";

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
