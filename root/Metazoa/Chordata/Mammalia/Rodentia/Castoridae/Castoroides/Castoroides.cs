using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Castoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Castoridae.Castoroides;

/// <summary>
/// Abstract class for Castoroides (genus).
/// NCBI TaxId: 2863006
/// </summary>
public abstract class Castoroides : Castoridae, ICastoroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Castoroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2863006;

    /// <inheritdoc />
    public virtual string GenusName => "Castoroides";

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
