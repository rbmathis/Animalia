using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Cryptoprocta;

/// <summary>
/// Abstract class for Cryptoprocta (genus).
/// NCBI TaxId: 94187
/// </summary>
public abstract class Cryptoprocta : Eupleridae, ICryptoprocta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptoprocta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94187;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptoprocta";

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
