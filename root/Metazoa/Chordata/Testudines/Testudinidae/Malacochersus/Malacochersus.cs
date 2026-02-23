using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Malacochersus;

/// <summary>
/// Abstract class for Malacochersus (genus).
/// NCBI TaxId: 286008
/// </summary>
public abstract class Malacochersus : Testudinidae, IMalacochersus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacochersus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286008;

    /// <inheritdoc />
    public virtual string GenusName => "Malacochersus";

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
