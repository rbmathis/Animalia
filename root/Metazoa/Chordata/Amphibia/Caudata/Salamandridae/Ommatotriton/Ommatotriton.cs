using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Ommatotriton;

/// <summary>
/// Abstract class for Ommatotriton (genus).
/// NCBI TaxId: 454751
/// </summary>
public abstract class Ommatotriton : Salamandridae, IOmmatotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ommatotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 454751;

    /// <inheritdoc />
    public virtual string GenusName => "Ommatotriton";

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
