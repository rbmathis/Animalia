using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Henicorhynchus;

/// <summary>
/// Abstract class for Henicorhynchus (genus).
/// NCBI TaxId: 369629
/// </summary>
public abstract class Henicorhynchus : Cyprinidae, IHenicorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Henicorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369629;

    /// <inheritdoc />
    public virtual string GenusName => "Henicorhynchus";

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
