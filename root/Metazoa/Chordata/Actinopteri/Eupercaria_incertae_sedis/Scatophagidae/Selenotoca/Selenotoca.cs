using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae.Selenotoca;

/// <summary>
/// Abstract class for Selenotoca (genus).
/// NCBI TaxId: 75039
/// </summary>
public abstract class Selenotoca : Scatophagidae, ISelenotoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selenotoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75039;

    /// <inheritdoc />
    public virtual string GenusName => "Selenotoca";

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
