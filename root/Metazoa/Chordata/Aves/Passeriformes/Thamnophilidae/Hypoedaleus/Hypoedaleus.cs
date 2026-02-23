using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Hypoedaleus;

/// <summary>
/// Abstract class for Hypoedaleus (genus).
/// NCBI TaxId: 288051
/// </summary>
public abstract class Hypoedaleus : Thamnophilidae, IHypoedaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypoedaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288051;

    /// <inheritdoc />
    public virtual string GenusName => "Hypoedaleus";

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
