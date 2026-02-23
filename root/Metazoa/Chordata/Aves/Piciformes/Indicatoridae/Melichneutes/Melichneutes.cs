using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Melichneutes;

/// <summary>
/// Abstract class for Melichneutes (genus).
/// NCBI TaxId: 1002799
/// </summary>
public abstract class Melichneutes : Indicatoridae, IMelichneutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melichneutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002799;

    /// <inheritdoc />
    public virtual string GenusName => "Melichneutes";

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
