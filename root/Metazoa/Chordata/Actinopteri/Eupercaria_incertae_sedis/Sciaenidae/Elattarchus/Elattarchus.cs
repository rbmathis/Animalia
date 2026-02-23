using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Elattarchus;

/// <summary>
/// Abstract class for Elattarchus (genus).
/// NCBI TaxId: 3043146
/// </summary>
public abstract class Elattarchus : Sciaenidae, IElattarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elattarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3043146;

    /// <inheritdoc />
    public virtual string GenusName => "Elattarchus";

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
