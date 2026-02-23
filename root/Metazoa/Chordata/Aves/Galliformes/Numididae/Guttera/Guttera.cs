using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Guttera;

/// <summary>
/// Abstract class for Guttera (genus).
/// NCBI TaxId: 8993
/// </summary>
public abstract class Guttera : Numididae, IGuttera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guttera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8993;

    /// <inheritdoc />
    public virtual string GenusName => "Guttera";

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
