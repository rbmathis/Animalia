using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Cabassous;

/// <summary>
/// Abstract class for Cabassous (genus).
/// NCBI TaxId: 48851
/// </summary>
public abstract class Cabassous : Chlamyphoridae, ICabassous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cabassous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48851;

    /// <inheritdoc />
    public virtual string GenusName => "Cabassous";

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
