using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Chilatherina;

/// <summary>
/// Abstract class for Chilatherina (genus).
/// NCBI TaxId: 300297
/// </summary>
public abstract class Chilatherina : Melanotaeniidae, IChilatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300297;

    /// <inheritdoc />
    public virtual string GenusName => "Chilatherina";

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
