using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Bahaba;

/// <summary>
/// Abstract class for Bahaba (genus).
/// NCBI TaxId: 912803
/// </summary>
public abstract class Bahaba : Sciaenidae, IBahaba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bahaba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 912803;

    /// <inheritdoc />
    public virtual string GenusName => "Bahaba";

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
