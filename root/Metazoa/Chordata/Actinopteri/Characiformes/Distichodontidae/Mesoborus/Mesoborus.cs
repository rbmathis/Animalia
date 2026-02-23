using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Mesoborus;

/// <summary>
/// Abstract class for Mesoborus (genus).
/// NCBI TaxId: 1108591
/// </summary>
public abstract class Mesoborus : Distichodontidae, IMesoborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesoborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108591;

    /// <inheritdoc />
    public virtual string GenusName => "Mesoborus";

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
