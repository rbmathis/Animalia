using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Neocrex;

/// <summary>
/// Abstract class for Neocrex (genus).
/// NCBI TaxId: 1294524
/// </summary>
public abstract class Neocrex : Rallidae, INeocrex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocrex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1294524;

    /// <inheritdoc />
    public virtual string GenusName => "Neocrex";

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
