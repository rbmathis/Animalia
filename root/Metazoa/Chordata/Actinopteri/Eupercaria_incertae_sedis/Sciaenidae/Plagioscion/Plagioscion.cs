using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Plagioscion;

/// <summary>
/// Abstract class for Plagioscion (genus).
/// NCBI TaxId: 254543
/// </summary>
public abstract class Plagioscion : Sciaenidae, IPlagioscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plagioscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254543;

    /// <inheritdoc />
    public virtual string GenusName => "Plagioscion";

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
