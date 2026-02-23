using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Gonocephalus;

/// <summary>
/// Abstract class for Gonocephalus (genus).
/// NCBI TaxId: 103700
/// </summary>
public abstract class Gonocephalus : Agamidae, IGonocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103700;

    /// <inheritdoc />
    public virtual string GenusName => "Gonocephalus";

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
