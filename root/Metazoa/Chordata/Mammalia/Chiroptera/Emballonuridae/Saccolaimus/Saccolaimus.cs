using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Saccolaimus;

/// <summary>
/// Abstract class for Saccolaimus (genus).
/// NCBI TaxId: 446909
/// </summary>
public abstract class Saccolaimus : Emballonuridae, ISaccolaimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saccolaimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446909;

    /// <inheritdoc />
    public virtual string GenusName => "Saccolaimus";

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
