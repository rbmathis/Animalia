using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Euleptorhamphus;

/// <summary>
/// Abstract class for Euleptorhamphus (genus).
/// NCBI TaxId: 293912
/// </summary>
public abstract class Euleptorhamphus : Hemiramphidae, IEuleptorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euleptorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293912;

    /// <inheritdoc />
    public virtual string GenusName => "Euleptorhamphus";

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
