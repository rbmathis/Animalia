using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Pomacanthus;

/// <summary>
/// Abstract class for Pomacanthus (genus).
/// NCBI TaxId: 51797
/// </summary>
public abstract class Pomacanthus : Pomacanthidae, IPomacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51797;

    /// <inheritdoc />
    public virtual string GenusName => "Pomacanthus";

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
