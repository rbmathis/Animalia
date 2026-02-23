using AnimalKingdom.root.Metazoa.Chordata.Aves.Cariamiformes.Cariamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cariamiformes.Cariamidae.Chunga;

/// <summary>
/// Abstract class for Chunga (genus).
/// NCBI TaxId: 1352769
/// </summary>
public abstract class Chunga : Cariamidae, IChunga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chunga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1352769;

    /// <inheritdoc />
    public virtual string GenusName => "Chunga";

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
