using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Carlito;

/// <summary>
/// Abstract class for Carlito (genus).
/// NCBI TaxId: 1868481
/// </summary>
public abstract class Carlito : Tarsiidae, ICarlito
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carlito";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1868481;

    /// <inheritdoc />
    public virtual string GenusName => "Carlito";

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
