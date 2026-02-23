using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Ocyceros;

/// <summary>
/// Abstract class for Ocyceros (genus).
/// NCBI TaxId: 866444
/// </summary>
public abstract class Ocyceros : Bucerotidae, IOcyceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ocyceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 866444;

    /// <inheritdoc />
    public virtual string GenusName => "Ocyceros";

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
