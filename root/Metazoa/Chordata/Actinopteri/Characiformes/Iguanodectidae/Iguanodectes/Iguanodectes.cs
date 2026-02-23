using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Iguanodectes;

/// <summary>
/// Abstract class for Iguanodectes (genus).
/// NCBI TaxId: 767256
/// </summary>
public abstract class Iguanodectes : Iguanodectidae, IIguanodectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iguanodectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 767256;

    /// <inheritdoc />
    public virtual string GenusName => "Iguanodectes";

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
