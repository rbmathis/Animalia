using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pterotolithus;

/// <summary>
/// Abstract class for Pterotolithus (genus).
/// NCBI TaxId: 1642211
/// </summary>
public abstract class Pterotolithus : Sciaenidae, IPterotolithus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterotolithus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642211;

    /// <inheritdoc />
    public virtual string GenusName => "Pterotolithus";

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
