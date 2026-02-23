using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Rhynchorhamphus;

/// <summary>
/// Abstract class for Rhynchorhamphus (genus).
/// NCBI TaxId: 1175560
/// </summary>
public abstract class Rhynchorhamphus : Hemiramphidae, IRhynchorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1175560;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchorhamphus";

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
