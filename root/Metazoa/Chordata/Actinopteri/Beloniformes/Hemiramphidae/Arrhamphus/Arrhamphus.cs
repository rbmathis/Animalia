using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Arrhamphus;

/// <summary>
/// Abstract class for Arrhamphus (genus).
/// NCBI TaxId: 159451
/// </summary>
public abstract class Arrhamphus : Hemiramphidae, IArrhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arrhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 159451;

    /// <inheritdoc />
    public virtual string GenusName => "Arrhamphus";

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
