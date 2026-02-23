using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Enhydra;

/// <summary>
/// Abstract class for Enhydra (genus).
/// NCBI TaxId: 34881
/// </summary>
public abstract class Enhydra : Mustelidae, IEnhydra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enhydra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34881;

    /// <inheritdoc />
    public virtual string GenusName => "Enhydra";

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
