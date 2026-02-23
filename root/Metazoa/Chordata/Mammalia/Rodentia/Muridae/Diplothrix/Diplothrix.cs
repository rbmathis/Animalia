using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Diplothrix;

/// <summary>
/// Abstract class for Diplothrix (genus).
/// NCBI TaxId: 106282
/// </summary>
public abstract class Diplothrix : Muridae, IDiplothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106282;

    /// <inheritdoc />
    public virtual string GenusName => "Diplothrix";

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
