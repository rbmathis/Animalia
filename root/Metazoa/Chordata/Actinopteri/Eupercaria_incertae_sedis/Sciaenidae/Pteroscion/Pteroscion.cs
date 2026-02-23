using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pteroscion;

/// <summary>
/// Abstract class for Pteroscion (genus).
/// NCBI TaxId: 1642209
/// </summary>
public abstract class Pteroscion : Sciaenidae, IPteroscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteroscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642209;

    /// <inheritdoc />
    public virtual string GenusName => "Pteroscion";

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
