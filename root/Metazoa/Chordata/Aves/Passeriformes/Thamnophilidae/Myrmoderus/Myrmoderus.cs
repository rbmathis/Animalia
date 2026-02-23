using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmoderus;

/// <summary>
/// Abstract class for Myrmoderus (genus).
/// NCBI TaxId: 2133929
/// </summary>
public abstract class Myrmoderus : Thamnophilidae, IMyrmoderus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmoderus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2133929;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmoderus";

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
