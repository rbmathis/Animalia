using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Triphoturus;

/// <summary>
/// Abstract class for Triphoturus (genus).
/// NCBI TaxId: 123242
/// </summary>
public abstract class Triphoturus : Myctophidae, ITriphoturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triphoturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123242;

    /// <inheritdoc />
    public virtual string GenusName => "Triphoturus";

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
