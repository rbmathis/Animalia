using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Poropuntius;

/// <summary>
/// Abstract class for Poropuntius (genus).
/// NCBI TaxId: 497005
/// </summary>
public abstract class Poropuntius : Cyprinidae, IPoropuntius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poropuntius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497005;

    /// <inheritdoc />
    public virtual string GenusName => "Poropuntius";

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
