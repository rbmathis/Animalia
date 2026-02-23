using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae.Dallia;

/// <summary>
/// Abstract class for Dallia (genus).
/// NCBI TaxId: 75938
/// </summary>
public abstract class Dallia : Umbridae, IDallia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dallia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75938;

    /// <inheritdoc />
    public virtual string GenusName => "Dallia";

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
