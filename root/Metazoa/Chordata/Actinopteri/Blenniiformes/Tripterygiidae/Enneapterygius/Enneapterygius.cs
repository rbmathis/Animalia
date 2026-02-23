using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Enneapterygius;

/// <summary>
/// Abstract class for Enneapterygius (genus).
/// NCBI TaxId: 130720
/// </summary>
public abstract class Enneapterygius : Tripterygiidae, IEnneapterygius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enneapterygius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 130720;

    /// <inheritdoc />
    public virtual string GenusName => "Enneapterygius";

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
