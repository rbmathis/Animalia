using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Laotriton;

/// <summary>
/// Abstract class for Laotriton (genus).
/// NCBI TaxId: 1331677
/// </summary>
public abstract class Laotriton : Salamandridae, ILaotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1331677;

    /// <inheritdoc />
    public virtual string GenusName => "Laotriton";

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
