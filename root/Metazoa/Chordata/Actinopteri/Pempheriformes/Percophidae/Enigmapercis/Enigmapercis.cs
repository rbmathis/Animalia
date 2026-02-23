using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Enigmapercis;

/// <summary>
/// Abstract class for Enigmapercis (genus).
/// NCBI TaxId: 1703795
/// </summary>
public abstract class Enigmapercis : Percophidae, IEnigmapercis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enigmapercis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1703795;

    /// <inheritdoc />
    public virtual string GenusName => "Enigmapercis";

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
