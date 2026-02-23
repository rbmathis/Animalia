using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Genicanthus;

/// <summary>
/// Abstract class for Genicanthus (genus).
/// NCBI TaxId: 109911
/// </summary>
public abstract class Genicanthus : Pomacanthidae, IGenicanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genicanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109911;

    /// <inheritdoc />
    public virtual string GenusName => "Genicanthus";

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
