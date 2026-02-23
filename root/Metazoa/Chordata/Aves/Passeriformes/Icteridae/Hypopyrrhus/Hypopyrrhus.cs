using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Hypopyrrhus;

/// <summary>
/// Abstract class for Hypopyrrhus (genus).
/// NCBI TaxId: 269179
/// </summary>
public abstract class Hypopyrrhus : Icteridae, IHypopyrrhus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypopyrrhus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269179;

    /// <inheritdoc />
    public virtual string GenusName => "Hypopyrrhus";

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
