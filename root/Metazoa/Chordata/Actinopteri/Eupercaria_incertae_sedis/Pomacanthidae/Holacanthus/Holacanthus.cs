using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Holacanthus;

/// <summary>
/// Abstract class for Holacanthus (genus).
/// NCBI TaxId: 75023
/// </summary>
public abstract class Holacanthus : Pomacanthidae, IHolacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75023;

    /// <inheritdoc />
    public virtual string GenusName => "Holacanthus";

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
