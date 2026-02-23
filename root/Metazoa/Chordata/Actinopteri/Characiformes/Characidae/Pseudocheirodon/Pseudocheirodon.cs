using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Pseudocheirodon;

/// <summary>
/// Abstract class for Pseudocheirodon (genus).
/// NCBI TaxId: 1076482
/// </summary>
public abstract class Pseudocheirodon : Characidae, IPseudocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1076482;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocheirodon";

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
