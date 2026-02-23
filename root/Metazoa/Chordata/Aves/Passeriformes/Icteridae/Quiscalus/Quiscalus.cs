using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Quiscalus;

/// <summary>
/// Abstract class for Quiscalus (genus).
/// NCBI TaxId: 64277
/// </summary>
public abstract class Quiscalus : Icteridae, IQuiscalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Quiscalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64277;

    /// <inheritdoc />
    public virtual string GenusName => "Quiscalus";

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
