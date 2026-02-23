using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Hemiramphus;

/// <summary>
/// Abstract class for Hemiramphus (genus).
/// NCBI TaxId: 88695
/// </summary>
public abstract class Hemiramphus : Hemiramphidae, IHemiramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88695;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiramphus";

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
