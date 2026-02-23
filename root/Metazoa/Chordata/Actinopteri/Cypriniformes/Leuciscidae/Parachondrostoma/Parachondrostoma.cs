using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Parachondrostoma;

/// <summary>
/// Abstract class for Parachondrostoma (genus).
/// NCBI TaxId: 437170
/// </summary>
public abstract class Parachondrostoma : Leuciscidae, IParachondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 437170;

    /// <inheritdoc />
    public virtual string GenusName => "Parachondrostoma";

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
