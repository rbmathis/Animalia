using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Gastromyzon;

/// <summary>
/// Abstract class for Gastromyzon (genus).
/// NCBI TaxId: 241454
/// </summary>
public abstract class Gastromyzon : Gastromyzontidae, IGastromyzon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastromyzon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241454;

    /// <inheritdoc />
    public virtual string GenusName => "Gastromyzon";

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
