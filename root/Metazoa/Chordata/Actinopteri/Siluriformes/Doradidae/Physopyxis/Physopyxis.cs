using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Physopyxis;

/// <summary>
/// Abstract class for Physopyxis (genus).
/// NCBI TaxId: 238566
/// </summary>
public abstract class Physopyxis : Doradidae, IPhysopyxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Physopyxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238566;

    /// <inheritdoc />
    public virtual string GenusName => "Physopyxis";

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
