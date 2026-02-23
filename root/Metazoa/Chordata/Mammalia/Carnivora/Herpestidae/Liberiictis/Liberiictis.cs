using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Liberiictis;

/// <summary>
/// Abstract class for Liberiictis (genus).
/// NCBI TaxId: 210649
/// </summary>
public abstract class Liberiictis : Herpestidae, ILiberiictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liberiictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210649;

    /// <inheritdoc />
    public virtual string GenusName => "Liberiictis";

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
