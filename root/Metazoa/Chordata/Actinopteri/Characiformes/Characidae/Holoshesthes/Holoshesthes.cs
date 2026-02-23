using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Holoshesthes;

/// <summary>
/// Abstract class for Holoshesthes (genus).
/// NCBI TaxId: 3363424
/// </summary>
public abstract class Holoshesthes : Characidae, IHoloshesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holoshesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363424;

    /// <inheritdoc />
    public virtual string GenusName => "Holoshesthes";

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
