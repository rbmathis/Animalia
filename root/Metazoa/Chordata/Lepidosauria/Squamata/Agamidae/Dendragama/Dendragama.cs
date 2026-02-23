using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Dendragama;

/// <summary>
/// Abstract class for Dendragama (genus).
/// NCBI TaxId: 1544558
/// </summary>
public abstract class Dendragama : Agamidae, IDendragama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendragama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544558;

    /// <inheritdoc />
    public virtual string GenusName => "Dendragama";

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
