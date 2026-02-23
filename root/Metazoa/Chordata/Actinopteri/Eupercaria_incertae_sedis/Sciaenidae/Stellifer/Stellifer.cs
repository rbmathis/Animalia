using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Stellifer;

/// <summary>
/// Abstract class for Stellifer (genus).
/// NCBI TaxId: 278772
/// </summary>
public abstract class Stellifer : Sciaenidae, IStellifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stellifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 278772;

    /// <inheritdoc />
    public virtual string GenusName => "Stellifer";

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
