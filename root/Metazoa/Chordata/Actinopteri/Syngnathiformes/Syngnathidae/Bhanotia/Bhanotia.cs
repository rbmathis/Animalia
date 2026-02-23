using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Bhanotia;

/// <summary>
/// Abstract class for Bhanotia (genus).
/// NCBI TaxId: 1914715
/// </summary>
public abstract class Bhanotia : Syngnathidae, IBhanotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bhanotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914715;

    /// <inheritdoc />
    public virtual string GenusName => "Bhanotia";

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
