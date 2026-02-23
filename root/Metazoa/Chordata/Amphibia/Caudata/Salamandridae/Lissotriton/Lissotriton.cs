using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Lissotriton;

/// <summary>
/// Abstract class for Lissotriton (genus).
/// NCBI TaxId: 339868
/// </summary>
public abstract class Lissotriton : Salamandridae, ILissotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lissotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 339868;

    /// <inheritdoc />
    public virtual string GenusName => "Lissotriton";

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
