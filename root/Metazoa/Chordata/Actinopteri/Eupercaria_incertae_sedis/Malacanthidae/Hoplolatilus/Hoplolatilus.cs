using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Hoplolatilus;

/// <summary>
/// Abstract class for Hoplolatilus (genus).
/// NCBI TaxId: 274801
/// </summary>
public abstract class Hoplolatilus : Malacanthidae, IHoplolatilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplolatilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274801;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplolatilus";

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
