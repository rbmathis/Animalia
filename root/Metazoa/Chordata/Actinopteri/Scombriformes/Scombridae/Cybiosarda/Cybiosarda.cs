using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Cybiosarda;

/// <summary>
/// Abstract class for Cybiosarda (genus).
/// NCBI TaxId: 248141
/// </summary>
public abstract class Cybiosarda : Scombridae, ICybiosarda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cybiosarda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248141;

    /// <inheritdoc />
    public virtual string GenusName => "Cybiosarda";

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
