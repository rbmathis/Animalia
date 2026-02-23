using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Oxyporhamphus;

/// <summary>
/// Abstract class for Oxyporhamphus (genus).
/// NCBI TaxId: 293901
/// </summary>
public abstract class Oxyporhamphus : Hemiramphidae, IOxyporhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyporhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293901;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyporhamphus";

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
