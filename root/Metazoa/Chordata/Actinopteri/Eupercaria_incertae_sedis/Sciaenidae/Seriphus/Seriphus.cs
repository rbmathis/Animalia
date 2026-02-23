using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Seriphus;

/// <summary>
/// Abstract class for Seriphus (genus).
/// NCBI TaxId: 515230
/// </summary>
public abstract class Seriphus : Sciaenidae, ISeriphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seriphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 515230;

    /// <inheritdoc />
    public virtual string GenusName => "Seriphus";

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
