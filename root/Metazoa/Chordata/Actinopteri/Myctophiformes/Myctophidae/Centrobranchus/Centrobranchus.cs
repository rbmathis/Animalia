using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Centrobranchus;

/// <summary>
/// Abstract class for Centrobranchus (genus).
/// NCBI TaxId: 123341
/// </summary>
public abstract class Centrobranchus : Myctophidae, ICentrobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123341;

    /// <inheritdoc />
    public virtual string GenusName => "Centrobranchus";

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
