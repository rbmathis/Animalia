using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Hyporhamphus;

/// <summary>
/// Abstract class for Hyporhamphus (genus).
/// NCBI TaxId: 115870
/// </summary>
public abstract class Hyporhamphus : Hemiramphidae, IHyporhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyporhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115870;

    /// <inheritdoc />
    public virtual string GenusName => "Hyporhamphus";

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
