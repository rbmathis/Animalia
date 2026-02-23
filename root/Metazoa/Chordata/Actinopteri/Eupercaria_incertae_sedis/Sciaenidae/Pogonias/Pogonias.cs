using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pogonias;

/// <summary>
/// Abstract class for Pogonias (genus).
/// NCBI TaxId: 329430
/// </summary>
public abstract class Pogonias : Sciaenidae, IPogonias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329430;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonias";

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
