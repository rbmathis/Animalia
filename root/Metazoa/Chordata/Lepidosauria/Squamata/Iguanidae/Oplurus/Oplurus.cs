using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Oplurus;

/// <summary>
/// Abstract class for Oplurus (genus).
/// NCBI TaxId: 43603
/// </summary>
public abstract class Oplurus : Iguanidae, IOplurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oplurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43603;

    /// <inheritdoc />
    public virtual string GenusName => "Oplurus";

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
