using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Melanotis;

/// <summary>
/// Abstract class for Melanotis (genus).
/// NCBI TaxId: 111992
/// </summary>
public abstract class Melanotis : Sturnidae, IMelanotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111992;

    /// <inheritdoc />
    public virtual string GenusName => "Melanotis";

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
