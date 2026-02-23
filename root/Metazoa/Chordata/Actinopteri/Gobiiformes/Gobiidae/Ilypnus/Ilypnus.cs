using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ilypnus;

/// <summary>
/// Abstract class for Ilypnus (genus).
/// NCBI TaxId: 185743
/// </summary>
public abstract class Ilypnus : Gobiidae, IIlypnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ilypnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185743;

    /// <inheritdoc />
    public virtual string GenusName => "Ilypnus";

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
