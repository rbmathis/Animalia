using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Mora;

/// <summary>
/// Abstract class for Mora (genus).
/// NCBI TaxId: 210579
/// </summary>
public abstract class Mora : Moridae, IMora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210579;

    /// <inheritdoc />
    public virtual string GenusName => "Mora";

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
