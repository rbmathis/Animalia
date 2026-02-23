using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Cryptosylvicola;

/// <summary>
/// Abstract class for Cryptosylvicola (genus).
/// NCBI TaxId: 98122
/// </summary>
public abstract class Cryptosylvicola : Bernieridae, ICryptosylvicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptosylvicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98122;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptosylvicola";

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
