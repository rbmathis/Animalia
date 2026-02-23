using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Nototriton;

/// <summary>
/// Abstract class for Nototriton (genus).
/// NCBI TaxId: 107967
/// </summary>
public abstract class Nototriton : Plethodontidae, INototriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nototriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107967;

    /// <inheritdoc />
    public virtual string GenusName => "Nototriton";

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
