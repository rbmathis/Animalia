using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Callanthiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Callanthiidae.Callanthias;

/// <summary>
/// Abstract class for Callanthias (genus).
/// NCBI TaxId: 270593
/// </summary>
public abstract class Callanthias : Callanthiidae, ICallanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270593;

    /// <inheritdoc />
    public virtual string GenusName => "Callanthias";

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
