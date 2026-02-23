using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Crex;

/// <summary>
/// Abstract class for Crex (genus).
/// NCBI TaxId: 185585
/// </summary>
public abstract class Crex : Rallidae, ICrex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185585;

    /// <inheritdoc />
    public virtual string GenusName => "Crex";

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
