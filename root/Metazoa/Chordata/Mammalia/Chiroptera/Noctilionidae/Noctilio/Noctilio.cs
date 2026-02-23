using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Noctilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Noctilionidae.Noctilio;

/// <summary>
/// Abstract class for Noctilio (genus).
/// NCBI TaxId: 94958
/// </summary>
public abstract class Noctilio : Noctilionidae, INoctilio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Noctilio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94958;

    /// <inheritdoc />
    public virtual string GenusName => "Noctilio";

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
