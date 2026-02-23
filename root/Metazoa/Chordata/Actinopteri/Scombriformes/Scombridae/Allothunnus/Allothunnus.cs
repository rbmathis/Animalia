using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Allothunnus;

/// <summary>
/// Abstract class for Allothunnus (genus).
/// NCBI TaxId: 320456
/// </summary>
public abstract class Allothunnus : Scombridae, IAllothunnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allothunnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320456;

    /// <inheritdoc />
    public virtual string GenusName => "Allothunnus";

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
