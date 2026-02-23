using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Chrysomus;

/// <summary>
/// Abstract class for Chrysomus (genus).
/// NCBI TaxId: 555142
/// </summary>
public abstract class Chrysomus : Icteridae, IChrysomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555142;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysomus";

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
