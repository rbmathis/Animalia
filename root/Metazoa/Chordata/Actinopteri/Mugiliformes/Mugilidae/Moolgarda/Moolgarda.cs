using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Moolgarda;

/// <summary>
/// Abstract class for Moolgarda (genus).
/// NCBI TaxId: 1111164
/// </summary>
public abstract class Moolgarda : Mugilidae, IMoolgarda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moolgarda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1111164;

    /// <inheritdoc />
    public virtual string GenusName => "Moolgarda";

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
