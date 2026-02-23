using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Salminus;

/// <summary>
/// Abstract class for Salminus (genus).
/// NCBI TaxId: 42583
/// </summary>
public abstract class Salminus : Bryconidae, ISalminus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salminus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42583;

    /// <inheritdoc />
    public virtual string GenusName => "Salminus";

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
