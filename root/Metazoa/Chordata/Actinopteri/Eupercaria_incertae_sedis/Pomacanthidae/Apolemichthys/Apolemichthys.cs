using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Apolemichthys;

/// <summary>
/// Abstract class for Apolemichthys (genus).
/// NCBI TaxId: 109716
/// </summary>
public abstract class Apolemichthys : Pomacanthidae, IApolemichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apolemichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109716;

    /// <inheritdoc />
    public virtual string GenusName => "Apolemichthys";

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
