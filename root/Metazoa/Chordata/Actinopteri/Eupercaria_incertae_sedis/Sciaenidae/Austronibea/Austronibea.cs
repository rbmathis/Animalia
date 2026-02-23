using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Austronibea;

/// <summary>
/// Abstract class for Austronibea (genus).
/// NCBI TaxId: 1642203
/// </summary>
public abstract class Austronibea : Sciaenidae, IAustronibea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austronibea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642203;

    /// <inheritdoc />
    public virtual string GenusName => "Austronibea";

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
