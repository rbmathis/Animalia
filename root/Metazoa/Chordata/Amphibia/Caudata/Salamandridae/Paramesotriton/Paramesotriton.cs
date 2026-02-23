using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Paramesotriton;

/// <summary>
/// Abstract class for Paramesotriton (genus).
/// NCBI TaxId: 164968
/// </summary>
public abstract class Paramesotriton : Salamandridae, IParamesotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramesotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164968;

    /// <inheritdoc />
    public virtual string GenusName => "Paramesotriton";

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
