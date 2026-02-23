using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Lopholatilus;

/// <summary>
/// Abstract class for Lopholatilus (genus).
/// NCBI TaxId: 390348
/// </summary>
public abstract class Lopholatilus : Malacanthidae, ILopholatilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lopholatilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390348;

    /// <inheritdoc />
    public virtual string GenusName => "Lopholatilus";

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
