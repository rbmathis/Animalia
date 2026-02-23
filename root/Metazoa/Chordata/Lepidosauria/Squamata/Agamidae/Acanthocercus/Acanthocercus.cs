using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Acanthocercus;

/// <summary>
/// Abstract class for Acanthocercus (genus).
/// NCBI TaxId: 690288
/// </summary>
public abstract class Acanthocercus : Agamidae, IAcanthocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 690288;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthocercus";

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
