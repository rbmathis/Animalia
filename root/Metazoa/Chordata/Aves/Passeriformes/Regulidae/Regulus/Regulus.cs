using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Regulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Regulidae.Regulus;

/// <summary>
/// Abstract class for Regulus (genus).
/// NCBI TaxId: 13244
/// </summary>
public abstract class Regulus : Regulidae, IRegulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Regulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13244;

    /// <inheritdoc />
    public virtual string GenusName => "Regulus";

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
