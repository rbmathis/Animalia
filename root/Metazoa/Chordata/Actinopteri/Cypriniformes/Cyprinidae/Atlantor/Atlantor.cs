using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Atlantor;

/// <summary>
/// Abstract class for Atlantor (genus).
/// NCBI TaxId: 3363388
/// </summary>
public abstract class Atlantor : Cyprinidae, IAtlantor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atlantor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363388;

    /// <inheritdoc />
    public virtual string GenusName => "Atlantor";

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
