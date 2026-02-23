using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pachyurus;

/// <summary>
/// Abstract class for Pachyurus (genus).
/// NCBI TaxId: 1170317
/// </summary>
public abstract class Pachyurus : Sciaenidae, IPachyurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachyurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1170317;

    /// <inheritdoc />
    public virtual string GenusName => "Pachyurus";

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
