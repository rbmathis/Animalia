using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Fregatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Fregatidae.Fregata;

/// <summary>
/// Abstract class for Fregata (genus).
/// NCBI TaxId: 37041
/// </summary>
public abstract class Fregata : Fregatidae, IFregata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fregata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37041;

    /// <inheritdoc />
    public virtual string GenusName => "Fregata";

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
