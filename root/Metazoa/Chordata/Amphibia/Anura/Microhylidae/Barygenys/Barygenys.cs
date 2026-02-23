using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Barygenys;

/// <summary>
/// Abstract class for Barygenys (genus).
/// NCBI TaxId: 326990
/// </summary>
public abstract class Barygenys : Microhylidae, IBarygenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barygenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326990;

    /// <inheritdoc />
    public virtual string GenusName => "Barygenys";

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
