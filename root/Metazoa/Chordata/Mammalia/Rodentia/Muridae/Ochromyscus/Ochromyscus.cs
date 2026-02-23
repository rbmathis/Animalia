using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Ochromyscus;

/// <summary>
/// Abstract class for Ochromyscus (genus).
/// NCBI TaxId: 3035879
/// </summary>
public abstract class Ochromyscus : Muridae, IOchromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ochromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3035879;

    /// <inheritdoc />
    public virtual string GenusName => "Ochromyscus";

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
