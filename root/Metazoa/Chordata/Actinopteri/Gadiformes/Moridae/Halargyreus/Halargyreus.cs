using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Halargyreus;

/// <summary>
/// Abstract class for Halargyreus (genus).
/// NCBI TaxId: 319452
/// </summary>
public abstract class Halargyreus : Moridae, IHalargyreus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halargyreus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319452;

    /// <inheritdoc />
    public virtual string GenusName => "Halargyreus";

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
