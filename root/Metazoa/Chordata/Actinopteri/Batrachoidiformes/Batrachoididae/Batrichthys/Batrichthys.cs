using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Batrichthys;

/// <summary>
/// Abstract class for Batrichthys (genus).
/// NCBI TaxId: 990938
/// </summary>
public abstract class Batrichthys : Batrachoididae, IBatrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990938;

    /// <inheritdoc />
    public virtual string GenusName => "Batrichthys";

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
