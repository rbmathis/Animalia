using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Chalcomitra;

/// <summary>
/// Abstract class for Chalcomitra (genus).
/// NCBI TaxId: 570429
/// </summary>
public abstract class Chalcomitra : Nectariniidae, IChalcomitra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcomitra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 570429;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcomitra";

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
