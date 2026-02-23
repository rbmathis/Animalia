using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Megalonibea;

/// <summary>
/// Abstract class for Megalonibea (genus).
/// NCBI TaxId: 1477496
/// </summary>
public abstract class Megalonibea : Sciaenidae, IMegalonibea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalonibea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1477496;

    /// <inheritdoc />
    public virtual string GenusName => "Megalonibea";

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
