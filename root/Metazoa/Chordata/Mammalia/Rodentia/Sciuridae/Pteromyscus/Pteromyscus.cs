using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Pteromyscus;

/// <summary>
/// Abstract class for Pteromyscus (genus).
/// NCBI TaxId: 226816
/// </summary>
public abstract class Pteromyscus : Sciuridae, IPteromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226816;

    /// <inheritdoc />
    public virtual string GenusName => "Pteromyscus";

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
