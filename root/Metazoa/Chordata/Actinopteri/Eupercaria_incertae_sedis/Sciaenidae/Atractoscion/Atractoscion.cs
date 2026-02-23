using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Atractoscion;

/// <summary>
/// Abstract class for Atractoscion (genus).
/// NCBI TaxId: 259702
/// </summary>
public abstract class Atractoscion : Sciaenidae, IAtractoscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atractoscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 259702;

    /// <inheritdoc />
    public virtual string GenusName => "Atractoscion";

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
