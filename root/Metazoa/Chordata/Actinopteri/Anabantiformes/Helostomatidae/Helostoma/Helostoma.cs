using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Helostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Helostomatidae.Helostoma;

/// <summary>
/// Abstract class for Helostoma (genus).
/// NCBI TaxId: 243707
/// </summary>
public abstract class Helostoma : Helostomatidae, IHelostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 243707;

    /// <inheritdoc />
    public virtual string GenusName => "Helostoma";

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
