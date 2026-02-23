using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Sclerophrys;

/// <summary>
/// Abstract class for Sclerophrys (genus).
/// NCBI TaxId: 1862675
/// </summary>
public abstract class Sclerophrys : Bufonidae, ISclerophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sclerophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1862675;

    /// <inheritdoc />
    public virtual string GenusName => "Sclerophrys";

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
