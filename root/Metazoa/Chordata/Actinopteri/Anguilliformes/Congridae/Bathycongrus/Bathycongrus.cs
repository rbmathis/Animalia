using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathycongrus;

/// <summary>
/// Abstract class for Bathycongrus (genus).
/// NCBI TaxId: 190105
/// </summary>
public abstract class Bathycongrus : Congridae, IBathycongrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathycongrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190105;

    /// <inheritdoc />
    public virtual string GenusName => "Bathycongrus";

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
