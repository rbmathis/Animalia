using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Basiliscus;

/// <summary>
/// Abstract class for Basiliscus (genus).
/// NCBI TaxId: 52190
/// </summary>
public abstract class Basiliscus : Iguanidae, IBasiliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Basiliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52190;

    /// <inheritdoc />
    public virtual string GenusName => "Basiliscus";

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
