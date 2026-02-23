using AnimalKingdom.root.Metazoa.Chordata.Aves.Cariamiformes.Cariamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cariamiformes.Cariamidae.Cariama;

/// <summary>
/// Abstract class for Cariama (genus).
/// NCBI TaxId: 54379
/// </summary>
public abstract class Cariama : Cariamidae, ICariama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cariama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54379;

    /// <inheritdoc />
    public virtual string GenusName => "Cariama";

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
