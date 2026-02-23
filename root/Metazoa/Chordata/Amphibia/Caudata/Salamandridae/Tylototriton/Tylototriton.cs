using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Tylototriton;

/// <summary>
/// Abstract class for Tylototriton (genus).
/// NCBI TaxId: 129884
/// </summary>
public abstract class Tylototriton : Salamandridae, ITylototriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tylototriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129884;

    /// <inheritdoc />
    public virtual string GenusName => "Tylototriton";

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
