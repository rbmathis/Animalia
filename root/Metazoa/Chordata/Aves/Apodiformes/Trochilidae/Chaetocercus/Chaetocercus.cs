using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chaetocercus;

/// <summary>
/// Abstract class for Chaetocercus (genus).
/// NCBI TaxId: 472789
/// </summary>
public abstract class Chaetocercus : Trochilidae, IChaetocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472789;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetocercus";

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
