using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Mertensiella;

/// <summary>
/// Abstract class for Mertensiella (genus).
/// NCBI TaxId: 111424
/// </summary>
public abstract class Mertensiella : Salamandridae, IMertensiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mertensiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111424;

    /// <inheritdoc />
    public virtual string GenusName => "Mertensiella";

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
