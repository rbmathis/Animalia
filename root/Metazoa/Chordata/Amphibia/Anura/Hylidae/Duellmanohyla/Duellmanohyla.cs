using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Duellmanohyla;

/// <summary>
/// Abstract class for Duellmanohyla (genus).
/// NCBI TaxId: 279978
/// </summary>
public abstract class Duellmanohyla : Hylidae, IDuellmanohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Duellmanohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 279978;

    /// <inheritdoc />
    public virtual string GenusName => "Duellmanohyla";

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
