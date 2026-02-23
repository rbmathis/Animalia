using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Thinocoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Thinocoridae.Attagis;

/// <summary>
/// Abstract class for Attagis (genus).
/// NCBI TaxId: 227232
/// </summary>
public abstract class Attagis : Thinocoridae, IAttagis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Attagis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227232;

    /// <inheritdoc />
    public virtual string GenusName => "Attagis";

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
