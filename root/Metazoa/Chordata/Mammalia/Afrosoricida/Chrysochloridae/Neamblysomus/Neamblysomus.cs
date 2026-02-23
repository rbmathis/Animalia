using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Neamblysomus;

/// <summary>
/// Abstract class for Neamblysomus (genus).
/// NCBI TaxId: 745253
/// </summary>
public abstract class Neamblysomus : Chrysochloridae, INeamblysomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neamblysomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745253;

    /// <inheritdoc />
    public virtual string GenusName => "Neamblysomus";

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
