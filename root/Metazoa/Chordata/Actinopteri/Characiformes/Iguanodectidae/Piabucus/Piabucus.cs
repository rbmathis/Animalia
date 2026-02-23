using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Piabucus;

/// <summary>
/// Abstract class for Piabucus (genus).
/// NCBI TaxId: 930372
/// </summary>
public abstract class Piabucus : Iguanodectidae, IPiabucus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Piabucus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930372;

    /// <inheritdoc />
    public virtual string GenusName => "Piabucus";

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
