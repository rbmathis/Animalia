using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Papyrocranus;

/// <summary>
/// Abstract class for Papyrocranus (genus).
/// NCBI TaxId: 113546
/// </summary>
public abstract class Papyrocranus : Notopteridae, IPapyrocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papyrocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 113546;

    /// <inheritdoc />
    public virtual string GenusName => "Papyrocranus";

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
