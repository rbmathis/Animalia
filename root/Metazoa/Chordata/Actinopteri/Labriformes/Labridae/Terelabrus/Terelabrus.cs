using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Terelabrus;

/// <summary>
/// Abstract class for Terelabrus (genus).
/// NCBI TaxId: 1984849
/// </summary>
public abstract class Terelabrus : Labridae, ITerelabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Terelabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1984849;

    /// <inheritdoc />
    public virtual string GenusName => "Terelabrus";

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
