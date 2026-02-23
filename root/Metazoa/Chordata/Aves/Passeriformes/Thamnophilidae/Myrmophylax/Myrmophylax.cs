using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmophylax;

/// <summary>
/// Abstract class for Myrmophylax (genus).
/// NCBI TaxId: 2767938
/// </summary>
public abstract class Myrmophylax : Thamnophilidae, IMyrmophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767938;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmophylax";

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
