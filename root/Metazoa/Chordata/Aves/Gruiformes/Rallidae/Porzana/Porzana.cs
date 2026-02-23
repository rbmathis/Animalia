using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Porzana;

/// <summary>
/// Abstract class for Porzana (genus).
/// NCBI TaxId: 54491
/// </summary>
public abstract class Porzana : Rallidae, IPorzana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porzana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54491;

    /// <inheritdoc />
    public virtual string GenusName => "Porzana";

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
