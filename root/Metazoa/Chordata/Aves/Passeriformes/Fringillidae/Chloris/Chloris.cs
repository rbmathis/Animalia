using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chloris;

/// <summary>
/// Abstract class for Chloris (genus).
/// NCBI TaxId: 1897773
/// </summary>
public abstract class Chloris : Fringillidae, IChloris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1897773;

    /// <inheritdoc />
    public virtual string GenusName => "Chloris";

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
