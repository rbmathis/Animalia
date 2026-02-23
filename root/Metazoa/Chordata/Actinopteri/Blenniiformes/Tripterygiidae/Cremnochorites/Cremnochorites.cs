using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Cremnochorites;

/// <summary>
/// Abstract class for Cremnochorites (genus).
/// NCBI TaxId: 879807
/// </summary>
public abstract class Cremnochorites : Tripterygiidae, ICremnochorites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cremnochorites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879807;

    /// <inheritdoc />
    public virtual string GenusName => "Cremnochorites";

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
