using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Peprilus;

/// <summary>
/// Abstract class for Peprilus (genus).
/// NCBI TaxId: 183652
/// </summary>
public abstract class Peprilus : Stromateidae, IPeprilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peprilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183652;

    /// <inheritdoc />
    public virtual string GenusName => "Peprilus";

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
