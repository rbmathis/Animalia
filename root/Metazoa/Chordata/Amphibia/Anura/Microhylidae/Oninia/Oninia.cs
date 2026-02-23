using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Oninia;

/// <summary>
/// Abstract class for Oninia (genus).
/// NCBI TaxId: 987051
/// </summary>
public abstract class Oninia : Microhylidae, IOninia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oninia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 987051;

    /// <inheritdoc />
    public virtual string GenusName => "Oninia";

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
