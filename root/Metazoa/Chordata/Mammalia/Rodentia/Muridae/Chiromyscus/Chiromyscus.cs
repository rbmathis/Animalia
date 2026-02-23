using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiromyscus;

/// <summary>
/// Abstract class for Chiromyscus (genus).
/// NCBI TaxId: 491871
/// </summary>
public abstract class Chiromyscus : Muridae, IChiromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491871;

    /// <inheritdoc />
    public virtual string GenusName => "Chiromyscus";

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
