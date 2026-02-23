using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Cyclarhis;

/// <summary>
/// Abstract class for Cyclarhis (genus).
/// NCBI TaxId: 34942
/// </summary>
public abstract class Cyclarhis : Vireonidae, ICyclarhis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclarhis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34942;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclarhis";

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
