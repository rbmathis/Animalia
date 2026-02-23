using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Haddadus;

/// <summary>
/// Abstract class for Haddadus (genus).
/// NCBI TaxId: 611783
/// </summary>
public abstract class Haddadus : Craugastoridae, IHaddadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haddadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 611783;

    /// <inheritdoc />
    public virtual string GenusName => "Haddadus";

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
