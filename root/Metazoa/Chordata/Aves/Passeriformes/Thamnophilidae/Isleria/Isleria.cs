using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Isleria;

/// <summary>
/// Abstract class for Isleria (genus).
/// NCBI TaxId: 2821867
/// </summary>
public abstract class Isleria : Thamnophilidae, IIsleria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isleria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821867;

    /// <inheritdoc />
    public virtual string GenusName => "Isleria";

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
