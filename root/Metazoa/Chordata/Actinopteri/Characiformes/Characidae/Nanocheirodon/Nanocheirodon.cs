using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Nanocheirodon;

/// <summary>
/// Abstract class for Nanocheirodon (genus).
/// NCBI TaxId: 930357
/// </summary>
public abstract class Nanocheirodon : Characidae, INanocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nanocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930357;

    /// <inheritdoc />
    public virtual string GenusName => "Nanocheirodon";

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
