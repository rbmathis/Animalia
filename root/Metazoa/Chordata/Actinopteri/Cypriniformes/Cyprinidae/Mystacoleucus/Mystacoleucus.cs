using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mystacoleucus;

/// <summary>
/// Abstract class for Mystacoleucus (genus).
/// NCBI TaxId: 192370
/// </summary>
public abstract class Mystacoleucus : Cyprinidae, IMystacoleucus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mystacoleucus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192370;

    /// <inheritdoc />
    public virtual string GenusName => "Mystacoleucus";

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
