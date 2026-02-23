using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Mantheyus;

/// <summary>
/// Abstract class for Mantheyus (genus).
/// NCBI TaxId: 282161
/// </summary>
public abstract class Mantheyus : Agamidae, IMantheyus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mantheyus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 282161;

    /// <inheritdoc />
    public virtual string GenusName => "Mantheyus";

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
