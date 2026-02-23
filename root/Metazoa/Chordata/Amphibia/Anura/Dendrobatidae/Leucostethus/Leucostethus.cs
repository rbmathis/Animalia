using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Leucostethus;

/// <summary>
/// Abstract class for Leucostethus (genus).
/// NCBI TaxId: 2483034
/// </summary>
public abstract class Leucostethus : Dendrobatidae, ILeucostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2483034;

    /// <inheritdoc />
    public virtual string GenusName => "Leucostethus";

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
