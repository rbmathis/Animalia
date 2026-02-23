using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Neurergus;

/// <summary>
/// Abstract class for Neurergus (genus).
/// NCBI TaxId: 213850
/// </summary>
public abstract class Neurergus : Salamandridae, INeurergus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neurergus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 213850;

    /// <inheritdoc />
    public virtual string GenusName => "Neurergus";

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
