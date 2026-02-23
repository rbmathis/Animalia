using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Melapedalion;

/// <summary>
/// Abstract class for Melapedalion (genus).
/// NCBI TaxId: 2067540
/// </summary>
public abstract class Melapedalion : Hemiramphidae, IMelapedalion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melapedalion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2067540;

    /// <inheritdoc />
    public virtual string GenusName => "Melapedalion";

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
