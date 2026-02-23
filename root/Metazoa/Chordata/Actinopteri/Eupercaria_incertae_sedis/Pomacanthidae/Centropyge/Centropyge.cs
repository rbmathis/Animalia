using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Centropyge;

/// <summary>
/// Abstract class for Centropyge (genus).
/// NCBI TaxId: 109718
/// </summary>
public abstract class Centropyge : Pomacanthidae, ICentropyge
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centropyge";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109718;

    /// <inheritdoc />
    public virtual string GenusName => "Centropyge";

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
