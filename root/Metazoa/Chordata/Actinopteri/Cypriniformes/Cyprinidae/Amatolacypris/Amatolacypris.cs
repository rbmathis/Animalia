using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Amatolacypris;

/// <summary>
/// Abstract class for Amatolacypris (genus).
/// NCBI TaxId: 3363382
/// </summary>
public abstract class Amatolacypris : Cyprinidae, IAmatolacypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amatolacypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363382;

    /// <inheritdoc />
    public virtual string GenusName => "Amatolacypris";

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
