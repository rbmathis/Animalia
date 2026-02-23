using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Ophioscion;

/// <summary>
/// Abstract class for Ophioscion (genus).
/// NCBI TaxId: 1241960
/// </summary>
public abstract class Ophioscion : Sciaenidae, IOphioscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophioscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1241960;

    /// <inheritdoc />
    public virtual string GenusName => "Ophioscion";

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
